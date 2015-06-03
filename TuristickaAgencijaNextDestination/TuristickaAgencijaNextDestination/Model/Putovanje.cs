using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaNextDestination.Model
{
    public enum PrevoznoSredstvo
    {
        avion,
        brod,
        autobus,
        voz
    }
    public enum PutnoOsiguranje
    {
        SarajevoOsiguranje,
        TriglavOsiguranje,
        SunceOsiguranje,
        ASAOsiguranje
    }
    public class Putovanje
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string destinacija;

        public string Destinacija
        {
            get { return destinacija; }
            set { destinacija = value; }
        }

        double cijena;

        public double Cijena
        {
            get { return cijena; }
            set { 
                //Obracun popusta
                if (Convert.ToBoolean(StatusKlijenta.penzioner) == true || Convert.ToBoolean(StatusKlijenta.student) == true )
                    cijena = cijena + cijena * 0.20;
                else
                cijena = value; }
        }
        DateTime datumPolaska;

        public DateTime DatumPolaska
        {
            get { return datumPolaska; }
            set { datumPolaska = value; }
        }
        DateTime datumDolaska;

        public DateTime DatumDolaska
        {
            get { return datumDolaska; }
            set { datumDolaska = value; }
        }
        int trajanjePutovanja;

        public int TrajanjePutovanja
        {
            get { return trajanjePutovanja; }
            set { trajanjePutovanja = value; }
        }
        int brojSlobodnihMjesta;

        public int BrojSlobodnihMjesta
        {
            get { return brojSlobodnihMjesta; }
            set { brojSlobodnihMjesta = value; }
        }
        PrevoznoSredstvo prevoznoSredstvo;

        public PrevoznoSredstvo PrevoznoSredstvo
        {
            get { return prevoznoSredstvo; }
            set { prevoznoSredstvo = value; }
        }
        PutnoOsiguranje putnoOsiguranje;

        public PutnoOsiguranje PutnoOsiguranje
        {
            get { return putnoOsiguranje; }
            set { putnoOsiguranje = value; }
        }
        public Putovanje() { }
        public Putovanje (string destinacija,double cijena,DateTime datumPolaska,DateTime datumDolaska,int trajanjePutovanja,int brojSlobodnihMjesta,PrevoznoSredstvo prevoznoSredstvo,PutnoOsiguranje putnoOsiguranje,int id)
        {
            this.id = id;
            this.destinacija = destinacija;
            this.cijena = cijena;
            this.datumPolaska = datumPolaska;
            this.datumDolaska = datumDolaska;
            this.trajanjePutovanja = trajanjePutovanja;
            this.brojSlobodnihMjesta = brojSlobodnihMjesta;
            this.prevoznoSredstvo = prevoznoSredstvo;
            this.putnoOsiguranje = putnoOsiguranje;

        }
        public void DodijeliID()
        {
            id = PutovanjeSaIzletom.listaPutovanja.Count + 1;
        }




    }
}
