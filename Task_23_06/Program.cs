namespace Task_23_06
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
        1. Выведите информации о всех дисках в системе
        2. Выведите содержимое каталога C:\Users (названия папок)
        3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
        a) Создание вложенного каталога “temp”
        b) Вывод информации о текущем каталоге (имя, родитель и тд)
        c) Вывод информации о вложенном каталоге
        4. Переместите каталог “temp” по пути “D:\work\newTemp”
        a) Реализуйте вывод информационного сообщения об успешном (или нет)
        перемещении
        5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
        удалении.*/
        static void Main(string[] args)
        { //Выведите информации о всех дисках в системе.
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            Console.WriteLine("Все диски в текущей системе:\n");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"{drive.Name}: Размер диска: {drive.TotalSize / 1024 / 1024 / 1024} Гб" +
                    $"\t Доступное место на диске: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} Гб\n" +
                    $"\t Тип диска: {drive.DriveType}\n" +
                    $"\t Метка диска: {drive.VolumeLabel}\n");
            }
            // Выведите содержимое каталога C:\Users (названия папок).
            string pathName = @"C:\Users";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Папки в каталоге {pathName}");
                List<String> list = Directory.GetDirectories(pathName).ToList();
                if (list.Count > 0)
                {
                    int n = 1;
                    foreach (String s in list)
                    {
                        Console.WriteLine(n + ":" + s);
                        n++;
                    }
                }
                else
                {
                    Console.WriteLine("Нет папок");
                }
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
            /*Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            a) Создание вложенного каталога “temp”
            b) Вывод информации о текущем каталоге (имя, родитель и тд)
            c) Вывод информации о вложенном каталоге
            Переместите каталог “temp” по пути “D:\work\newTemp”
            a) Реализуйте вывод информационного сообщения об успешном (или нет)
            перемещении
            5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
            удалении.**/
            string workDir = @"D:\work";
            try
            {
                Directory.CreateDirectory(workDir);
                string tempDir = Path.Combine(workDir, "temp");
                Directory.CreateDirectory(tempDir);
                DirectoryInfo workInfo = new DirectoryInfo(workDir);
                Console.WriteLine($"\nИнформация о каталоге {workDir}:" +
                    $"Имя файла: {workInfo.Name}" +
                    $"Родительский каталог:{workInfo.Parent} " +
                    $"Полное имя {workInfo.FullName}" +
                    $"Дата создания: {workInfo.CreationTime}");
                DirectoryInfo tempDirInfo = new DirectoryInfo(tempDir);
                Console.WriteLine($"\nИнформация о каталоге {tempDir}" +
                    $" Имя: {tempDirInfo.Name}" +
                    $" Полный путь: {tempDirInfo.FullName}" +
                    $" Родительский каталог: {tempDirInfo.Parent}" +
                    $" Дата создания: {tempDirInfo.CreationTime}");
                string newTempDir = Path.Combine(workDir, "newTemp");
                try
                {
                    Directory.Move(tempDir, newTempDir);
                    Console.WriteLine($"\nКаталог {tempDir} успешно перемещен в {newTempDir}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перемещении каталога: {ex.Message}");
                }
                
                try
                {
                    Directory.Delete(newTempDir, true);
                    Console.WriteLine($"\nКаталог {newTempDir} успешно удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при работе с каталогом {workDir}: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
