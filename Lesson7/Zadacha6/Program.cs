// Как посмотреть содержимое папки?

/* string path = "D:\Program Files\ProgramSeminars\Seminars\ProgramssC_Homework\Lesson7\Zadacha6";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles(); */ 

void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"D:\Program Files\ProgramSeminars\Seminars\ProgramssC_Homework\Lesson7\Zadacha6";
CatalogInfo(path);
