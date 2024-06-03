using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

public class Line
{
    public string Description { get; set; }
    public List<int> Coordinates { get; set; }
}

public class Receipt
{
    public List<Line> Lines { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string jsonResponse = @"
        {
            'lines': [
                {'description': 'TEŞEKKÜRLER', 'coordinates': [10, 10, 100, 30]},
                {'description': 'GUNEYDOĞU TEKS. GIDA INS SAN. LTD.STI.', 'coordinates': [10, 40, 300, 60]},
                {'description': 'ORNEKTEPE MAH.ETIBANK CAD.SARAY APT.', 'coordinates': [10, 70, 400, 90]},
                {'description': 'N:43-1 BEYOĞLU/ISTANBUL', 'coordinates': [10, 100, 250, 120]},
                {'description': 'GÜNEŞLİ V.D. 4350078928 V. NO.', 'coordinates': [10, 130, 300, 150]},
                {'description': 'TARIH : 26.08.2020', 'coordinates': [10, 160, 200, 180]},
                {'description': 'SAAT : 15:27', 'coordinates': [10, 190, 150, 210]},
                {'description': 'FİŞ NO : 0082', 'coordinates': [10, 220, 150, 240]},
                {'description': '54491250', 'coordinates': [10, 250, 150, 270]},
                {'description': '2 ADx 2,75', 'coordinates': [10, 280, 150, 300]},
                {'description': 'CC.COCA COLA CAM 200 08 *5,50', 'coordinates': [10, 310, 250, 330]},
                {'description': '2701084', 'coordinates': [10, 340, 150, 360]},
                {'description': '1,566 KGx 1,99', 'coordinates': [10, 370, 200, 390]},
                {'description': 'MANAV DOMATES PETEME *3,32', 'coordinates': [10, 400, 250, 420]},
                {'description': '2701076', 'coordinates': [10, 430, 150, 450]},
                {'description': '0,358 KGx 4,99', 'coordinates': [10, 460, 200, 480]},
                {'description': 'MANAV BIBER CARLISTO 08 *1,79', 'coordinates': [10, 490, 250, 510]},
                {'description': '4', 'coordinates': [10, 520, 50, 540]},
                {'description': 'EKMEK CIFTLI 01 *1,25', 'coordinates': [10, 550, 200, 570]},
                {'description': 'TOPKDV *0,80', 'coordinates': [10, 580, 150, 600]},
                {'description': 'TOPLAM *11,86', 'coordinates': [10, 610, 150, 630]},
                {'description': 'NAKİT *20,00', 'coordinates': [10, 640, 150, 660]},
                {'description': 'KDV KDV TUTARI KDV\'LI TOPLAM', 'coordinates': [10, 670, 300, 690]},
                {'description': '01 *0,01 *1,25', 'coordinates': [10, 700, 200, 720]},
                {'description': '08 *0,79 *10,61', 'coordinates': [10, 730, 200, 750]},
                {'description': 'KASİYER : SUPERVISOR', 'coordinates': [10, 760, 200, 780]},
                {'description': '00 0001/020/000084/1//82/', 'coordinates': [10, 790, 250, 810]},
                {'description': 'PARA USTÜ *8,14', 'coordinates': [10, 820, 150, 840]},
                {'description': 'KASİYER: 1', 'coordinates': [10, 850, 100, 870]},
                {'description': '2 NO:1330 EKÜ NO:0001', 'coordinates': [10, 880, 200, 900]},
                {'description': 'MF YAB 15017876', 'coordinates': [10, 910, 150, 930]}
            ]
        }";

        // Deserialize JSON response
        Receipt receipt = JsonConvert.DeserializeObject<Receipt>(jsonResponse);

        // Sort lines based on the vertical position (y-coordinate)
        var sortedLines = receipt.Lines.OrderBy(line => line.Coordinates[1]).ToList();

        // Print sorted lines
        foreach (var line in sortedLines)
        {
            Console.WriteLine(line.Description);
        }
    }
}
