using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;
    private bool _res;


        public Address(string street, string city, string state, int zip, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;
            _country = country;

        }
        //Check to see if the address is in the USA for shipping costs
        public bool IsInUSA()
        {
            if (_country == "USA")
            {
                _res = true;
            }
            else{
                _res = false;
            }
            return _res;
        }

        //return the Full Shipping Address
        public string ShippingAddress()
        {
            return $"{_street}\n{_city}, {_state}, {_zip}\n{_country}";
        }

}