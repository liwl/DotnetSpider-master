﻿using System;

namespace DotnetSpider.Sample
{

	public class Program
	{
		public static void Main(string[] args)
		{

            //BaseUsage.CrawlerPagesTraversal();
            //Spider1 s = new Spider1();
            //s.Run();
            //ConfigurableSpider.Run();


            BaiduSearchSpider baiduSearchSpider = new BaiduSearchSpider();
		    baiduSearchSpider.Run();
		    Console.WriteLine("Press any key to continue...");
		    Console.Read();

            //// Custmize processor and pipeline 完全自定义页面解析和数据管道
            //BaseUsage.CustmizeProcessorAndPipeline();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //// Crawler pages without traverse 采集指定页面不做遍历
            //BaseUsage.CrawlerPagesWithoutTraverse();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //// Crawler pages traversal 遍历整站
            //BaseUsage.CrawlerPagesTraversal();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //DDengEntitySpider dDengEntitySpider = new DDengEntitySpider();
            //dDengEntitySpider.Run();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //Cnblogs.Run();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //CasSpider casSpider = new CasSpider();
            //casSpider.Run();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //BaiduSearchSpider baiduSearchSpider = new BaiduSearchSpider();
            //baiduSearchSpider.Run();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //JdSkuSampleSpider jdSkuSampleSpider = new JdSkuSampleSpider();
            //jdSkuSampleSpider.Run();
            //Console.WriteLine("Press any key to continue...");
            //Console.Read();

            //Situoli.Run();
        }
    }
}
