﻿using System;
using System.Collections.Generic;
using System.Linq;
using BattleInfoPlugin.Models;
using Livet;
using Livet.EventListeners;

namespace BattleInfoPlugin.ViewModels
{
    public class FleetViewModel : ViewModel
    {

        #region Name変更通知プロパティ
        private string _Name;

        public string Name
        {
            get
            { return this._Name; }
            set
            { 
                if (this._Name == value)
                    return;
                this._Name = value;
                this.RaisePropertyChanged();
            }
        }
        #endregion


        #region Fleet変更通知プロパティ
        private FleetData _Fleet;

        public FleetData Fleet
        {
            get
            { return this._Fleet; }
            set
            {
                if (this._Fleet == value)
                    return;
                this._Fleet = value;
                this.RaisePropertyChanged();

                this.RaisePropertyChanged(() => this.FleetFormation);
                this.RaisePropertyChanged(() => this.IsVisible);

                this.Name = !string.IsNullOrWhiteSpace(value.Name)
                    ? value.Name
                    : this.defaultName;
            }
        }
        #endregion


        #region IsVisible変更通知プロパティ

        public bool IsVisible
        {
            get
            { return this.Fleet != null && this.Fleet.Ships.Count() != 0; }
        }
        #endregion


        #region FleetFormation変更通知プロパティ

        public string FleetFormation
        {
            get
            {
                return (this.Fleet != null && this.Fleet.Formation != Formation.なし)
                      ? this.Fleet.Formation.ToString()
                      : "";
            }
        }

        #endregion


        #region AirCombatResults変更通知プロパティ
        private AirCombatResultViewModel[] _AirCombatResults;

        public AirCombatResultViewModel[] AirCombatResults
        {
            get
            { return this._AirCombatResults; }
            set
            {
                if (this._AirCombatResults == value)
                    return;
                this._AirCombatResults = value;
                this.RaisePropertyChanged();
            }
        }
        #endregion


        public FleetViewModel() : this("")
        {
        }

        public FleetViewModel(string name)
        {
            this.defaultName = name;
            this._Name = name;
        }

        private readonly string defaultName;
    }
}
