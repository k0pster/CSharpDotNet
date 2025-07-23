// Program podsumowujący ilość plików w folderze w którym został uruchomiony

const string folder = "FileCollection";
const string resultsfile = "result.txt";

// Zmienne przechowujące rezultaty
long XLSCount = 0, DOCCount = 0, PPTCount = 0;
long XLSSize = 0, DOCSize = 0, PPTSize = 0;
long totalfiles = 0;
long totalsize = 0;

//logika sprawdzająca czy pliki w folderze są tymi, które chcemy zliczać
bool IsOfficeFile(string filename)
{
    if (filename.EndsWith(".xlsx") || filename.EndsWith(".docx") || filename.EndsWith(".pptx"))
    {
        return true;
    }
    return false;
}

//Tworzymy DirectoryInfo dla podanego folderu
DirectoryInfo di = new DirectoryInfo(folder);

//Zliczamy pliki po rodzajach
foreach (FileInfo fi in di.EnumerateFiles())
{
    //Czy jest to plik który mamy zaliczać(XLSX, DOCX, PPTX)
    if (IsOfficeFile(fi.Name))
    {
        totalfiles++; //zwiększamy licznik główny o jeden
        totalsize += fi.Length; //zwiększamy rozmiar główny o sprawdzany plik

        //Teraz logika per rodzaj pliku
        if (fi.Name.EndsWith(".xlsx"))
        {
            XLSCount++;
            XLSSize += fi.Length;
        }
        if (fi.Name.EndsWith(".docx"))
        {
            DOCCount++;
            DOCSize += fi.Length;
        }
        if (fi.Name.EndsWith(".pptx"))
        {
            PPTCount++;
            PPTSize += fi.Length;
        }
    }
}

//zapisujemy do pliku .txt i robimy output 
using (StreamWriter sw = File.CreateText(resultsfile))
{
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {totalfiles}");
    sw.WriteLine($"Excel Count: {XLSCount}");
    sw.WriteLine($"Word Count: {DOCCount}");
    sw.WriteLine($"PowerPoint Count: {PPTCount}");
    sw.WriteLine("~~~~");
    sw.WriteLine($"Total Size: {totalsize:N0}");
    sw.WriteLine($"Excel Size: {XLSSize:N0}");
    sw.WriteLine($"Word Size: {DOCSize:N0}");
    sw.WriteLine($"PowerPoint Size: {PPTSize:N0}");
}
