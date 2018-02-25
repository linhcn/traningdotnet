using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap2._1
{
    class Program
    {

        public static String KHONG = "không";
        public static String MOT = "một";
        public static String HAI = "hai";
        public static String BA = "ba";
        public static String BON = "bốn";
        public static String NAM = "năm";
        public static String SAU = "sáu";
        public static String BAY = "bảy";
        public static String TAM = "tám";
        public static String CHIN = "chín";
        public static String LAM = "lăm";
        public static String LE = "lẻ";
        public static String MUOI = "mươi";
        public static String MUOIF = "mười";
        public static String MOTS = "mốt";
        public static String TRAM = "trăm";
        public static String NGHIN = "nghìn";
        public static String TRIEU = "triệu";
        public static String TY = "tỷ";

        public static String[] number = { KHONG, MOT, HAI, BA, BON, NAM, SAU, BAY, TAM, CHIN };

        public static void main(String[] args)
        {
            Program program = new Program();
            Console.WriteLine("nhập và một số: ");
            String tam = Console.ReadLine();
                foreach(Object oj in program.readNum(tam))
            {

                }
            }


        }

        public static ArrayList readNum(String a)
        {
            ArrayList kq = new ArrayList();


            //Cắt chuổi string chử số ra thành các chuổi nhỏ 3 chử số
            ArrayList List_Num = Split(a, 3);

            while (List_Num.size() != 0)
            {
                //Xét 3 số đầu tiên của chuổi (số đầu tiên của List_Num)
                switch (List_Num.size() % 3)
                {
                    //3 số đó thuộc hàng trăm
                    case 1:
                        kq.AddAll(read_3num(List_Num.get(0)));
                        break;
                    // 3 số đó thuộc hàng nghìn
                    case 2:
                        ArrayList nghin = read_3num(List_Num.get(0));
                        if (!nghin.isEmpty())
                        {
                            kq.AddAll(nghin);
                            kq.Add(NGHIN);
                        }
                        break;
                    //3 số đó thuộc hàng triệu
                    case 0:
                        ArrayList trieu = read_3num(List_Num.get(0));
                        if (!trieu.isEmpty())
                        {
                            kq.AddAll(trieu);
                            kq.Add(TRIEU);
                        }
                        break;
                }

                //Xét nếu 3 số đó thuộc hàng tỷ
                if (List_Num.Count == (List_Num.Count / 3) * 3 + 1 && List_Num.Count != 1) kq.Add(TY);

                //Xóa 3 số đầu tiên để tiếp tục 3 số kế
                List_Num.Remove(0);
            }


            return kq;
        }

        public static ArrayList read_3num(String a)
        {
            ArrayList kq = new ArrayList();
            int num = -1;
            try { num = int.Parse(a); }
            catch (Exception ex) { }
            if (num == 0) return kq;




            int hang_tram = -1;
            try { hang_tram = int.Parse(a.Substring(0, 1)); }
            catch (Exception ex) { }
            int hang_chuc = -1;
            try { hang_chuc = int.Parse(a.Substring(1, 2)); }
            catch (Exception ex) { }
            int hang_dv = -1;
            try { hang_dv = int.Parse(a.Substring(2, 3)); }
            catch (Exception ex) { }


            //xét hàng trăm
            if (hang_tram != -1)
            {
                kq.Add(number[hang_tram]);
                kq.Add(TRAM);
            }


            //xét hàng chục
            switch (hang_chuc)
            {
                case -1:
                    break;
                case 1:
                    kq.Add(MUOIF);
                    break;
                case 0:
                    if (hang_dv != 0) kq.Add(LE);
                    break;
                default:
                    kq.Add(number[hang_chuc]);
                    kq.Add(MUOI);
                    break;
            }


            //xét hàng đơn vị
            switch (hang_dv)
            {
                case -1:
                    break;
                case 1:
                    if ((hang_chuc != 0) && (hang_chuc != 1) && (hang_chuc != -1))
                        kq.Add(MOTS);
                    else kq.Add(number[hang_dv]);
                    break;
                case 5:
                    if ((hang_chuc != 0) && (hang_chuc != -1))
                        kq.Add(LAM);
                    else kq.Add(number[hang_dv]);
                    break;
                case 0:
                    
                    if (kq == null) kq.Add(number[hang_dv]);
                    break;
                default:
                    kq.Add(number[hang_dv]);
                    break;
            }
            return kq;
        }

        public static ArrayList Split(String str, int chunkSize)
        {
            int du = str.Length % chunkSize;
            //Nếu độ dài chuổi không phải bội số của chunkSize thì thêm # vào trước cho đủ.
            if (du != 0)
                for (int i = 0; i < (chunkSize - du); i++) str = "#" + str;
            return splitStringEvery(str, chunkSize);
        }


        //Hàm cắt chuổi ra thành chuổi nhỏ
        public static ArrayList splitStringEvery(String s, int interval)
        {
            ArrayList arrList = new ArrayList();
            int arrayLength = (int)Math.Ceiling(((s.Length / (double)interval)));
            String[] result = new String[arrayLength];
            int j = 0;
            int lastIndex = result.Length - 1;
            for (int i = 0; i < lastIndex; i++)
            {
                result[i] = s.Substring(j, j + interval);
                j += interval;
            }
            result[lastIndex] = s.Substring(j);

            arrList.AddRange(Array.AsReadOnly(result));
            return arrList;
        }
    }
}
