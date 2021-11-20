using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140097
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        //menambahkan faultContract
        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exception
        /*output*/
        int Tambah(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exception
        /*output*/
        int Kurang(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exception
        /*output*/
        int Kali(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exception
        /*output*/
        int Bagi(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exception
        /*output*/
        Koordinat TKoordinat(Koordinat a, Koordinat b); //method
/*
        [OperationContract]
        *//*output*//*
        int Tambah(int a, int b); //method
        [OperationContract]
        *//*output*//*
        int Kurang(int a, int b); //input
        [OperationContract]
        *//*output*//*
        int Kali(int a, int b); 
        [OperationContract]
        *//*output*//*
        int Bagi(int a, int b);
        [OperationContract]
        Koordinat TKoordinat(Koordinat a, Koordinat b); //obj dari class*/
    }
    
    [DataContract]
    //menambahkan class
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }

    public class Koordinat
    {
        private int _x, _y; //attribut
        [DataMember] // membuka koor x,y
        public int X //properties
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y //properties
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}
