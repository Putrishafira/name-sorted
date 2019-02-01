using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace name_sorter
{
    public partial class Form1 : Form
    {
        List<Names> Unsorted = new List<Names>(); //list untuk menyimpan nama yang belum disort
        List<Names> Sorted = new List<Names>(); //list untuk menyimpan nama yang udah di sort

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            using (StreamReader reader = new StreamReader("/Users/Putri Shafira/Documents/name-sorter/unsorted-names-list.txt")) // untuk membaca file text unsorted-names-list.txt 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listRead.Items.Add(line); // menampilkan file text ke dalam listboxt
                    string firtsname = ""; // variable untuk menyimpan first name
                    string lastname = "";// variale untuk menyimpan last name
                    string[] nama = line.Split(' '); // untuk memisahkan string yang ada di variable 'line' dengan menggunakan ' '(spasi), hasil splitnya menjadi array of string maka variable untuk menyimpannya menggunakan "string[] nama" 
                                                    //string[] digunakan untuk declare array of string
                     
                    lastname = nama[nama.Length - 1];// untuk mengambil last name dari index terakhir

                    for (int i = 0; i<nama.Length-1; i++) //looping untuk menggabungkan dengan first name
                    {
                        firtsname += nama[i] + ' '; // concat / menggabungkan first name sampai degan index terakhir -1 (supaya lastname nya tidak ikut tergabung)
                                                    //ambil index terakhir menggunakan 'nama.length -1' << nama.length mengambil banyak item di dalam array 'nama', dan karena index dimulai dari 0 maka di -1
                    }
                    Unsorted.Add(new Names { firstname = firtsname, lastname = lastname });  //memasukkan hasil pemisahan firstname dan lastname ke variable 'unsorted' yang tipe datanya Names.
                }
                Sorted = Unsorted.OrderBy(x => x.lastname).ToList();//Sorted untuk menyimpan hasil sort dari unsorted
                                                                    //Unsorted.orderby adalah function dari c# algoritma sortingnya
                                                                    //x=>x.lastname bisa diurutin dengan apa saja seperti x=>x.firstname dan tidak harus dengan x, variable apa aja bisa misal name=>name.lastname dsb.
                                                                    //ini adalah syntax penulisan linq dan orderby nya bisa ditambah lagi dengan '.ThenBy'

                for (int i = 0; i< Unsorted.Count ; i++)//looping untuk memasukkan nama ke listbox
                {
                    
                    using (StreamWriter writer = new StreamWriter("/Users/Putri Shafira/Documents/name-sorter/sorted-names-list.txt")) ;

                    listSort.Items.Add(Sorted[i].firstname + Sorted[i].lastname);//memasukkannya harus sorted.firstname di gabung dengan sorted.lastname, untuk menampilkan firstname dan lastname
                    const string sPath = "/Users/Putri Shafira/Documents/name-sorter/sorted-names-list.txt";// membuat file "sorted-names-list.txt"
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                    foreach (var item in listSort.Items)
                    {
                        SaveFile.WriteLine(item.ToString()); //menympan data sorted yang ada pada listsort kedalam file "sorted-names-list.txt"
                    }
                    SaveFile.Close();
                    {
                        
                    }
                }

            }
                
        }
    }
}