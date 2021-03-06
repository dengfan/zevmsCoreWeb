using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using reWZ;
using ZEVMSWEB.Common;
using ZEVMSWEB.Models.Entities;

namespace ZEVMSWEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            ContentRootPath = env.ContentRootPath;

            var wzFilePath = Path.Combine(ContentRootPath, "wz", "Data.wz");
            WZFile = new WZFile(wzFilePath, WZVariant.Classic, true);
        }

        public string ContentRootPath { get; }
        public IConfiguration Configuration { get; }
        public WZFile WZFile { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddDbContext<zevms027Context>();
            services.AddSingleton(WZFile);
            services.AddSingleton(GetWzData());
        }

        public WzData GetWzData()
        {
            var wzData = new WzData();
            var dic = new Dictionary<int, string>();

            try
            {
                var stringDir = WZFile.MainDirectory.SingleOrDefault(d => d.Name == "String");
                var itemImgFile = stringDir.SingleOrDefault(f => f.Name == "Item.img");

                foreach (var imgDir in itemImgFile)
                {
                    if (imgDir.Name == "Eqp")
                    {
                        foreach (var subImgDir in imgDir)
                        {
                            foreach (var item in subImgDir)
                            {
                                var hasNameNode = item.HasChild("name");
                                var name = hasNameNode ? item["name"].ValueOrDefault("NO-NAME") : "NO-NAME";
                                dic.Put(Convert.ToInt32(item.Name), name);
                            }

                        }
                    }
                    else
                    {
                        foreach (var item in imgDir)
                        {
                            var hasNameNode = item.HasChild("name");
                            var name = hasNameNode ? item["name"].ValueOrDefault("NO-NAME") : "NO-NAME";
                            dic.Put(Convert.ToInt32(item.Name), name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            wzData.ItemIdAndNameDic = dic;
            return wzData;
        }

        // ����HTTP�ܵ�
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
