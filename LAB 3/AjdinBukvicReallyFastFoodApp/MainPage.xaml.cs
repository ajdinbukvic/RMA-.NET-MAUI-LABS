using AjdinBukvicReallyFastFoodApp.Models;

namespace AjdinBukvicReallyFastFoodApp;

public partial class MainPage : ContentPage
{
	public List<Jelo> Jela { get; set; }
    public List<Naselje> Naselja { get; set; }

    public MainPage()
	{
        Jela = new List<Jelo>
        { 
            new Jelo {Id=1, Icon="jelo1.png", Naziv="Burger", Cijena=10, Kalorije=250},
            new Jelo {Id=2, Icon="jelo2.png", Naziv="Pizza", Cijena=20, Kalorije=350},
            new Jelo {Id=3, Icon="jelo3.png", Naziv="Rolls", Cijena=30, Kalorije=450},
            new Jelo {Id=4, Icon="jelo4.png", Naziv="Soup", Cijena=40, Kalorije=150}
        };

        Naselja = new List<Naselje>
        {
            new Naselje {Id=1, Naziv="Centar", Udaljenost=1},
            new Naselje {Id=2, Naziv="Blatuša", Udaljenost=3},
            new Naselje {Id=3, Naziv="Crkvice", Udaljenost=3},
            new Naselje {Id=4, Naziv="Radakovo", Udaljenost=4}
        };

        InitializeComponent();

        BindingContext = this;

        odabranoNaselje.ItemsSource = Naselja;

	}

    public void OnToggled(object sender, ToggledEventArgs e)
    {
        if (dostava.IsToggled)
        {
            odabranoNaselje.InputTransparent = false;
            odabranoNaselje.IsEnabled = true;
        }
        else
        {
            odabranoNaselje.InputTransparent = true;
            odabranoNaselje.IsEnabled = false;
        }
    }

    public void OnClicked(object sender, EventArgs args)
    {
        double ukupnaCijena = 0;

        Jela[0].Odabrano = Jela[1].Odabrano = Jela[2].Odabrano = Jela[3].Odabrano = false;
        Jela[0].Kolicina = Jela[1].Kolicina = Jela[2].Kolicina = Jela[3].Kolicina = 0;

        if (jelo1.Text is null && jelo2.Text is null && jelo3.Text is null && jelo4.Text is null)
        {
            DisplayAlert("Greška", "Molimo unesite količinu za barem jedno jelo!", "OK");
            return;
        }
        else
        {
            try
            {
                if (!string.IsNullOrEmpty(jelo1.Text)) { Jela[0].Kolicina = int.Parse(jelo1.Text); Jela[0].Odabrano = true; }
                if (!string.IsNullOrEmpty(jelo2.Text)) { Jela[1].Kolicina = int.Parse(jelo2.Text); Jela[1].Odabrano = true; }
                if (!string.IsNullOrEmpty(jelo3.Text)) { Jela[2].Kolicina = int.Parse(jelo3.Text); Jela[2].Odabrano = true; }
                if (!string.IsNullOrEmpty(jelo4.Text)) { Jela[3].Kolicina = int.Parse(jelo4.Text); Jela[3].Odabrano = true; }

                foreach (Jelo jelo in Jela)
                {
                    if (jelo.Odabrano && jelo.Kolicina <= 0)
                    {
                        DisplayAlert("Greška", "Unesena količina ne može biti nula ili negativna!", "OK");
                        return;
                    }
                }

                foreach (Jelo jelo in Jela) if (jelo.Odabrano) ukupnaCijena += jelo.Kolicina * jelo.Cijena;
                  

                if (!dostava.IsToggled)
                {
                    DisplayAlert("Greška", "Uključite dostavu i odaberite naselje!", "OK");
                    return;
                }

                if (dostava.IsToggled)
                {
                    if(odabranoNaselje.SelectedItem is null)
                    {
                        DisplayAlert("Greška", "Odaberite naselje za dostavu!", "OK");
                        return;
                    }
                }

                ukupnaCijena += ukupnaCijena * 0.2;

                Naselje naselje = (Naselje)odabranoNaselje.SelectedItem;

                ukupnaCijena += naselje.Udaljenost * 0.1;
                

                int ukupnaKolicina = Jela.Where(jelo => jelo.Odabrano).Select(jelo => jelo.Kolicina).Sum();

                if (ukupnaKolicina == 0)
                {
                    DisplayAlert("Greška", "Niste unijeli količinu za dostavu!", "OK");
                    return;
                }
                int ukupnoVrijeme = (ukupnaKolicina * 5) + 20;

                DateTime vrijemeDostave = DateTime.Now.AddMinutes(ukupnoVrijeme);

                TimeSpan vrijemeUMinutama = TimeSpan.FromMinutes(ukupnoVrijeme);
                string vrijemeUSatima = vrijemeUMinutama.ToString(@"hh\:mm");

                string sati = vrijemeUSatima.Split(":")[0];
                string minute = vrijemeUSatima.Split(":")[1];

                string poruka = "***** Vaša narudžba *****" +
                                "\nUkupna vrijednost narudžbe: " + ukupnaCijena + " KM" +
                                "\nBroj porcija: " + ukupnaKolicina +
                                "\nUdaljenost za dostavu: " + naselje.Udaljenost + " km" +
                                "\nPredviđeno vrijeme dostave: " + sati + "h" + minute + "min" + 
                                "\nDatum i vrijeme: " + vrijemeDostave;

                DisplayAlert("Kalkulacija narudžbe", poruka, "OK");
            }
            catch
            {
                DisplayAlert("Greška", "Molimo unesite validne podatke za vašu narudžbu!", "OK");
            }
        }
    }

}

