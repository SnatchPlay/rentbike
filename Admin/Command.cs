﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1;
using NP_1.Factories;
using NP_1.RepInterface;

namespace Admin
{
    class Command
    {
        public ITechRep techRepository = FactoryProvider.GetFactory().GetTechRep();
        public ICallRep callRepository = FactoryProvider.GetFactory().GetCallRep();
        
        public IPlaceRep placeRepository = FactoryProvider.GetFactory().GetPlaceRep();
        //public IRepository<Technic> techRepository = new TechRep();
        //public IRepository<Call> callRepository = new CallRep();
        //public IRepository<Place> placeRepository = new PlaceRep();

        public void AddCall(string name, string surname, int stag)
        {

            //cout << "Type name:"; cin >> name;
            //cout << "Type surname:"; cin >> surname;
            //cout << "Type stag:"; cin >> stag;
            int calls = 0;

            Call call1;
            call1 = new Call(name, surname, stag, calls);

            callRepository.Add(call1);
        }
        public void AddTech(string name,string surname)
        {
            int rating, reports;
           // cout << "Type name:"; cin >> name;
            //cout << "Type surname:"; cin >> surname;
            rating = 0;
            reports = 0;

            Technic tech;
            tech = new Technic(name, surname, rating, reports);

            techRepository.Add(tech);

        }
        public string AllCall(int i)
        {
            
            string str = ""; 
            str = callRepository.Data[i].ToString()+"\n";
            return str;
            
        }
        public string AllTech(int i)
        {
            string str = "";
            str=techRepository.Data[i].ToString()+"\n";
            return str;
        }
        public void AddPoint(string street) {
            Place pl;
            pl = new Place(street);
            placeRepository.Data.Add(pl);
        }
        public string AllPoints(int i)
        {
            string str="";
            str = placeRepository.Data[i].Write()+"\n";
            return str;
                
        }
        public void DeleteTech(short i)
        {
            techRepository.Remove(i);
        }
    }
}
