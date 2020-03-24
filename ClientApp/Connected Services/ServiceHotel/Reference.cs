﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ServiceHotel {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHotel.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/rechercherChambre", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClientApp.ServiceHotel.Hotel[] rechercherChambre(string ville, string checkIn, string checkout, int prixmin, int prixmax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/rechercherChambre", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApp.ServiceHotel.Hotel[]> rechercherChambreAsync(string ville, string checkIn, string checkout, int prixmin, int prixmax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reserverChambres", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string reserverChambres(int id_hotel, string numero_chambres, string checkin, string checkout, string nom_client, string prenom_client, string num_passeport, string num_tel, string date_naissance, string num_carte, string cvv, string type, string date_expiration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reserverChambres", ReplyAction="*")]
        System.Threading.Tasks.Task<string> reserverChambresAsync(int id_hotel, string numero_chambres, string checkin, string checkout, string nom_client, string prenom_client, string num_passeport, string num_tel, string date_naissance, string num_carte, string cvv, string type, string date_expiration);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Hotel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Chambre[] chambresField;
        
        private int idField;
        
        private int nbr_étoilesField;
        
        private bool étatField;
        
        private string nomField;
        
        private string adresseField;
        
        private string paysField;
        
        private string villeField;
        
        private string num_telField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public Chambre[] Chambres {
            get {
                return this.chambresField;
            }
            set {
                this.chambresField = value;
                this.RaisePropertyChanged("Chambres");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Nbr_étoiles {
            get {
                return this.nbr_étoilesField;
            }
            set {
                this.nbr_étoilesField = value;
                this.RaisePropertyChanged("Nbr_étoiles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool État {
            get {
                return this.étatField;
            }
            set {
                this.étatField = value;
                this.RaisePropertyChanged("État");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("Nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Adresse {
            get {
                return this.adresseField;
            }
            set {
                this.adresseField = value;
                this.RaisePropertyChanged("Adresse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Pays {
            get {
                return this.paysField;
            }
            set {
                this.paysField = value;
                this.RaisePropertyChanged("Pays");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Ville {
            get {
                return this.villeField;
            }
            set {
                this.villeField = value;
                this.RaisePropertyChanged("Ville");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Num_tel {
            get {
                return this.num_telField;
            }
            set {
                this.num_telField = value;
                this.RaisePropertyChanged("Num_tel");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Chambre : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int numeroField;
        
        private int etageField;
        
        private string typeField;
        
        private int nbr_litsField;
        
        private int prixField;
        
        private Reservation[] reservationsField;
        
        private string imageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
                this.RaisePropertyChanged("Numero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Etage {
            get {
                return this.etageField;
            }
            set {
                this.etageField = value;
                this.RaisePropertyChanged("Etage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Nbr_lits {
            get {
                return this.nbr_litsField;
            }
            set {
                this.nbr_litsField = value;
                this.RaisePropertyChanged("Nbr_lits");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Prix {
            get {
                return this.prixField;
            }
            set {
                this.prixField = value;
                this.RaisePropertyChanged("Prix");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public Reservation[] Reservations {
            get {
                return this.reservationsField;
            }
            set {
                this.reservationsField = value;
                this.RaisePropertyChanged("Reservations");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
                this.RaisePropertyChanged("Image");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Reservation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private System.DateTime checkInField;
        
        private System.DateTime checkOutField;
        
        private int prix_resField;
        
        private Client clientField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime CheckIn {
            get {
                return this.checkInField;
            }
            set {
                this.checkInField = value;
                this.RaisePropertyChanged("CheckIn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime CheckOut {
            get {
                return this.checkOutField;
            }
            set {
                this.checkOutField = value;
                this.RaisePropertyChanged("CheckOut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Prix_res {
            get {
                return this.prix_resField;
            }
            set {
                this.prix_resField = value;
                this.RaisePropertyChanged("Prix_res");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Client Client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
                this.RaisePropertyChanged("Client");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Client : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nomField;
        
        private string prenomField;
        
        private string numPasseportField;
        
        private string num_telField;
        
        private System.DateTime date_naissanceField;
        
        private CarteCredit carteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("Nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Prenom {
            get {
                return this.prenomField;
            }
            set {
                this.prenomField = value;
                this.RaisePropertyChanged("Prenom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string NumPasseport {
            get {
                return this.numPasseportField;
            }
            set {
                this.numPasseportField = value;
                this.RaisePropertyChanged("NumPasseport");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Num_tel {
            get {
                return this.num_telField;
            }
            set {
                this.num_telField = value;
                this.RaisePropertyChanged("Num_tel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Date_naissance {
            get {
                return this.date_naissanceField;
            }
            set {
                this.date_naissanceField = value;
                this.RaisePropertyChanged("Date_naissance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public CarteCredit Carte {
            get {
                return this.carteField;
            }
            set {
                this.carteField = value;
                this.RaisePropertyChanged("Carte");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CarteCredit : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string num_carteField;
        
        private string cvvField;
        
        private string typeField;
        
        private string date_expirationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Num_carte {
            get {
                return this.num_carteField;
            }
            set {
                this.num_carteField = value;
                this.RaisePropertyChanged("Num_carte");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Cvv {
            get {
                return this.cvvField;
            }
            set {
                this.cvvField = value;
                this.RaisePropertyChanged("Cvv");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Date_expiration {
            get {
                return this.date_expirationField;
            }
            set {
                this.date_expirationField = value;
                this.RaisePropertyChanged("Date_expiration");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ClientApp.ServiceHotel.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ClientApp.ServiceHotel.WebService1Soap>, ClientApp.ServiceHotel.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientApp.ServiceHotel.Hotel[] rechercherChambre(string ville, string checkIn, string checkout, int prixmin, int prixmax) {
            return base.Channel.rechercherChambre(ville, checkIn, checkout, prixmin, prixmax);
        }
        
        public System.Threading.Tasks.Task<ClientApp.ServiceHotel.Hotel[]> rechercherChambreAsync(string ville, string checkIn, string checkout, int prixmin, int prixmax) {
            return base.Channel.rechercherChambreAsync(ville, checkIn, checkout, prixmin, prixmax);
        }
        
        public string reserverChambres(int id_hotel, string numero_chambres, string checkin, string checkout, string nom_client, string prenom_client, string num_passeport, string num_tel, string date_naissance, string num_carte, string cvv, string type, string date_expiration) {
            return base.Channel.reserverChambres(id_hotel, numero_chambres, checkin, checkout, nom_client, prenom_client, num_passeport, num_tel, date_naissance, num_carte, cvv, type, date_expiration);
        }
        
        public System.Threading.Tasks.Task<string> reserverChambresAsync(int id_hotel, string numero_chambres, string checkin, string checkout, string nom_client, string prenom_client, string num_passeport, string num_tel, string date_naissance, string num_carte, string cvv, string type, string date_expiration) {
            return base.Channel.reserverChambresAsync(id_hotel, numero_chambres, checkin, checkout, nom_client, prenom_client, num_passeport, num_tel, date_naissance, num_carte, cvv, type, date_expiration);
        }
    }
}
