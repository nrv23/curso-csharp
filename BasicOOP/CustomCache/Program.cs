using CustomCache.clasess;

Console.WriteLine("Simple Cache App");

var downloader = new CachingDataDownloader(
     new PrintingDataDonwloader( // esta clase y la de caching implementan la clase Slow por lo que ambas clases caching 
         // y Printing se estan ejecutando
        new SlowDataDownloader() // esta clase es la que tiene la funcion que trae datos
     )
);


Console.WriteLine(downloader.DownloadData("1"));
Console.WriteLine(downloader.DownloadData("1"));
Console.WriteLine(downloader.DownloadData("2"));
Console.WriteLine(downloader.DownloadData("2"));
Console.WriteLine(downloader.DownloadData("3"));
Console.WriteLine(downloader.DownloadData("3"));
Console.WriteLine(downloader.DownloadData("4"));
Console.WriteLine(downloader.DownloadData("4"));
Console.WriteLine(downloader.DownloadData("5"));
Console.WriteLine(downloader.DownloadData("5"));




Console.ReadKey();