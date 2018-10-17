# NIPWebApp
Krótka instrukcja jak to uruchomić.

1. Przebudowanie całej solucji w celu ściągnięcia odpowiednich paczek.
W przypadku, gdy odpowiednie paczki nie zostały zainstalowane, należy przebudować osobno oba projekty.

2. Utworzenie bazy danych:
a. Zmiana ścieżki w connectionstringu w plikach .config, we dwóch projektach. 	
   W moim przypadku connection string wyglądał tak: 
  
   <connectionStrings>
    <add name="NIPDb"
    connectionString="Data Source=(localDb)\LocalDB;AttachDbFileName=C:\Users\rwojciechowski\source\repos\NIPWebApp\NIPWebAppBase\App_Data\NIPDb.mdf;Integrated Security=True;MultipleActiveResultSets=True"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>
   
  "C:\Users\rwojciechowski\source\repos\" należy zmienić na swoją ścieżkę do pliku.
  
  Po zmianie ścieżki do pliku bazy danych w obu projektach, możemy przebudować ponownie projekty.

b. Wywołanie komendy "Update-Database -ConfigurationTypeName NIPWebAppBase.Migrations.Configuration" w Package Manager Console.
W przypadku błędu - "The term 'Update-Database' is not recognized as the name of a cmdlet" należy zamknąć Package Manager Console oraz Visual Studio, a następnie uruchomić je ponownie.

W tym momencie w folderze App_Data powinny pojawić się na pliki .mdf i .ldf, czyli nasza baza danych.

3. Możemy uruchamiać aplikację :)