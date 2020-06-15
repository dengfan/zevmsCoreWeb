using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using ZEVMSWEB.Common;
using ZEVMSWEB.Models.Entities;
using ZEVMSWEB.Models;
using reWZ;

namespace ZEVMSWEB.Controllers
{
    public class Zevms027Controller : Controller
    {
        private readonly ILogger<Zevms027Controller> _logger;
        private readonly AppSettings _appSettings;
        private readonly WZFile _wzFile;
        private readonly WzData _wzData;
        private readonly zevms027Context _context;

        public Zevms027Controller(ILogger<Zevms027Controller> logger, IOptions<AppSettings> appSettings, WZFile wzFile, WzData wzData, zevms027Context dbContext)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
            _wzFile = wzFile;
            _wzData = wzData;
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region 蓝蜗牛
        public IActionResult LWN()
        {
            return View();
        }

        public async Task<IActionResult> LWN_Characters(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["IdSortParm"] = string.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["LevelSortParm"] = sortOrder == "level" ? "level_desc" : "level";
            ViewData["CurrentFilter"] = searchString;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var characters = from c in _context.Characters where c.World.Value == 0 select c;
            if (!string.IsNullOrEmpty(searchString))
            {
                characters = characters.Where(c => c.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "id_desc":
                    characters = characters.OrderByDescending(c => c.Id);
                    break;
                case "level_desc":
                    characters = characters.OrderByDescending(c => c.Level);
                    break;
                case "level":
                    characters = characters.OrderBy(c => c.Level);
                    break;
                default:
                    characters = characters.OrderBy(c => c.Id);
                    break;
            }

            int pageSize = 50;
            return View(await PaginatedList<CharacterViewModel>.CreateAsync(characters.AsNoTracking().Select(c => new CharacterViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Level = c.Level ?? 0,
                Job = c.Job ?? 0,
            }), pageNumber ?? 1, pageSize));
        }

        //UNKNOWN(0),
        //EQUIP(1),
        //USE(2),
        //SETUP(3),
        //ETC(4),
        //CASH(5),
        //EQUIPPED(-1);

        public async Task<IActionResult> LWN_Auction(
            int inventoryType,
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["InventoryType"] = inventoryType;
            ViewData["ItemIdSortParm"] = string.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
            ViewData["CurrentFilter"] = searchString;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var searchItems = new List<int>();
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                searchItems = _wzData.ItemIdAndNameDic.Where(i => i.Value.Contains(searchString)).Select(i => i.Key).ToList();
            }

            var auctionItems = from o in _context.Auctionitems where o.Inventorytype == inventoryType select o;
            if (!string.IsNullOrEmpty(searchString))
            {
                if (searchItems.Count > 0)
                {
                    auctionItems = auctionItems.Where(o => searchItems.Contains(o.Itemid.Value));
                }
            }
            switch (sortOrder)
            {
                case "id_desc":
                    auctionItems = auctionItems.OrderByDescending(o => o.Itemid);
                    break;
                case "price_desc":
                    auctionItems = auctionItems.OrderByDescending(o => o.Price);
                    break;
                case "price":
                    auctionItems = auctionItems.OrderBy(o => o.Price);
                    break;
                default:
                    auctionItems = auctionItems.OrderBy(o => o.Itemid);
                    break;
            }

            int pageSize = 50;
            return View(await PaginatedList<AuctionItemViewModel>.CreateAsync(auctionItems.AsNoTracking().Select(o => new AuctionItemViewModel
            {
                Id = o.Id,
                InventoryType = o.Inventorytype.Value,
                ItemImageBase64String = WzData.GetImageBase64String(o.Itemid.Value, o.Inventorytype.Value, _wzFile),
                ItemId = o.Itemid.Value,
                ItemName = _wzData.ItemIdAndNameDic.ContainsKey(o.Itemid.Value) ? _wzData.ItemIdAndNameDic[o.Itemid.Value] : "",
                Price = o.Price.Value,
                Quantity = o.Quantity.Value,
                OwnerCharacterId = o.Characterid.Value,
                OwnerCharacterName = o.Character.Name,
                Strong = o.Str.Value,
                Dexterity=o.Dex.Value,
                Intelligence = o.Int.Value,
                Luck = o.Luk.Value,
                WAtk = o.Watk.Value,
                WDef = o.Wdef.Value,
                MAtk = o.Matk.Value,
                MDef = o.Mdef.Value,
                Dkfm = o.Options,
            }), pageNumber ?? 1, pageSize));
        }
        #endregion

        #region 蘑菇仔
        public IActionResult MGZ()
        {
            return View();
        }

        public async Task<IActionResult> MGZ_Characters(string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["IdSortParm"] = string.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["LevelSortParm"] = sortOrder == "level" ? "level_desc" : "level";
            ViewData["CurrentFilter"] = searchString;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var characters = from c in _context.Characters where c.World.Value == 0 select c;
            if (!string.IsNullOrEmpty(searchString))
            {
                characters = characters.Where(c => c.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "id_desc":
                    characters = characters.OrderByDescending(c => c.Id);
                    break;
                case "level_desc":
                    characters = characters.OrderByDescending(c => c.Level);
                    break;
                case "level":
                    characters = characters.OrderBy(c => c.Level);
                    break;
                default:
                    characters = characters.OrderBy(c => c.Id);
                    break;
            }

            int pageSize = 50;
            return View(await PaginatedList<CharacterViewModel>.CreateAsync(characters.AsNoTracking().Select(c => new CharacterViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Level = c.Level ?? 0,
                Job = c.Job ?? 0,
            }), pageNumber ?? 1, pageSize));
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
