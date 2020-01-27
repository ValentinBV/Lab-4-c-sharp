using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Labs_33;

namespace Labs_44
{
    public partial class Form1 : Form
    {
        private CountryCollection countryCollection = new CountryCollection();
        private List<Car> carsCollection = new List<Car>();
        private List<Service> serviceCollection = new List<Service>();
        public Form1()
        {
            InitializeComponent();
            ShowCarsType();
        }

        private void Button_AddCountry_Click(object sender, EventArgs e)
        {
            string countryCode = textBox_CountryCode.Text;
            string countryName = textBox_CountryName.Text;
            try
            {
                Country country = new Country(countryCode, countryName);
                countryCollection.Add(country);
                RefreshListCountry();
                textBox_CountryCode.Clear();
                textBox_CountryName.Clear();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listCountry = (ListBox)sender;
            int currentIndex = listCountry.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Удалить " + listCountry.SelectedItem.ToString() + " ?", 
                "Подтверждение удаления", MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    countryCollection.Remove(currentIndex);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshListCountry();
            }
            
        }

        private void RefreshListCountry()
        {
            listCountry.Items.Clear();
            listBox_CarsCountry.Items.Clear();
            countryCollection.GetCollection().ForEach(delegate(Country countryItem)
            {
                listCountry.Items.Add(countryItem.Code + " " + countryItem.Name);
                listBox_CarsCountry.Items.Add(countryItem.Code + " " + countryItem.Name);
            });
        }

        private void Button_AddCar_Click(object sender, EventArgs e)
        {

            
            int currentIndex = listBox_CarsCountry.SelectedIndex;
            
            try
            {
                int carYear = int.Parse(textBox_CarYear.Text);
                float carWeight = float.Parse(textBox_CarWeight.Text);
                CarsType carsType = (CarsType)listBox_CarsType.SelectedItem;
                Car car = new PassengerCar(carsType);
                car.Weight = carWeight;
                car.Year = carYear;
                car.Country = countryCollection.GetCollection()[currentIndex];
                carsCollection.Add(car);
                RefreshListCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ShowCarsType()
        {
            Array carsTypeValues = Enum.GetValues(typeof(CarsType));
            foreach (CarsType value in carsTypeValues)
            {
                listBox_CarsType.Items.Add(value);
            }
        }

        private void RefreshListCars()
        {
            listBox_CarsList.Items.Clear();
            carsCollection.ForEach(delegate (Car carItem)
            {
                listBox_CarsList.Items.Add(
                    "Год - " + carItem.Year + " Вес " 
                    + carItem.Weight + " Тип " 
                    + carItem.CarsType
                    + " Страна " + carItem.Country.Name
                );
                listBox_ServiceCarsQueue.Items.Add(
                    "Год - " + carItem.Year + " Вес "
                    + carItem.Weight + " Тип "
                    + carItem.CarsType
                    + " Страна " + carItem.Country.Name
                );
            });
        }

        private void ListBox_CarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox carsList = (ListBox)sender;
            int currentIndex = carsList.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Удалить " + carsList.SelectedItem.ToString() + " ?",
                "Подтверждение удаления", MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    carsCollection.RemoveAt(currentIndex);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshListCars();
            }

        }

        private void Button_AddCarToService_Click(object sender, EventArgs e)
        {
            try
            {
                string staffName = textBox_ServiceStaffName.Text;
                string clientName = textBox_ServiceClientName.Text;
                Service service = new Service(staffName, clientName);
                int currentCarsIndex = listBox_ServiceCarsQueue.SelectedIndex;
                service.AddCar(carsCollection[currentCarsIndex]);
                serviceCollection.Add(service);
                RefreshListCarsInService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RefreshListCarsInService()
        {
            listBox_ServiceCarsInService.Items.Clear();
            string serviceSheet;
            serviceCollection.ForEach(delegate (Service serviceItem)
            {
                serviceSheet = "Мастер " + serviceItem.StaffName + " Клиент " + serviceItem.ClientName;
                serviceItem.GetCarsCollection().ForEach(delegate (Car carItem)
                {
                    listBox_ServiceCarsInService.Items.Add(
                        serviceSheet
                        + "Год - " + carItem.Year + " Вес "
                        + carItem.Weight + " Тип "
                        + carItem.CarsType
                        + " Страна " + carItem.Country.Name
                   );
                });
            });
        }

        private void ListBox_ServiceCarsInService_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox serviceList = (ListBox)sender;
            int currentIndex = serviceList.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Удалить " + serviceList.SelectedItem.ToString() + " ?",
                "Подтверждение удаления", MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    serviceCollection.RemoveAt(currentIndex);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshListCarsInService();
            }
        }
    }
}
