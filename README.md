*MAUI MVVM example*

This was created using VS 2017 Mac version 7.5.1, updated with version 7.6.8 and updated to MAUI with VS Mac 17.4.

The source for this is released under the MIT license. 

The original (forked) source was from [MSDN](https://code.msdn.microsoft.com/windowsapps/SQlite-sample-for-c4293b10) based on this [article](https://bsubramanyamraju.blogspot.com/2018/03/xamarinforms-mvvm-sqlite-sample-for.html).

The problems with the original was that it didn't work on the Android emulator and died with the System.DllNotFoundException for (/system/lib/libsqlite.so)

The PCL SQLite nuget [SQLite.Net NuGet package](https://www.nuget.org/packages/SQLite.Net-PCL) is no longer updated.

What I did was switched it out with the PCL [sqlite-net-pcl Nuget package](https://www.nuget.org/packages/sqlite-net-pcl), which works at present.

I also fixed many UI problems that the original had, such as infinite add / list views.