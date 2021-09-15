using Microsoft.EntityFrameworkCore;
using Pizza.UI.Extensions;
using PizzaLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.UI.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private static MainViewModel _instance;

        public static MainViewModel Instance => _instance ?? (_instance = new MainViewModel());

        private MainViewModel()
        {

        }

        private string _restaurantName;

        public string RestaurantName
        {
            get { return _restaurantName; }
            set
            {
                if (_restaurantName != value)
                {
                    _restaurantName = value;
                    OnPropertyChanged(nameof(RestaurantName));
                }
            }
        }

        private Restaurant _currentRestaurant;

        public Restaurant CurrentRestaurant
        {
            get { return _currentRestaurant; }
            set
            {
                if (_currentRestaurant != value)
                {
                    _currentRestaurant = value;
                    OnPropertyChanged(nameof(CurrentRestaurant));

                    CurrentPizzaAvailable = _currentRestaurant != null;

                    _ = GetPizzaAsync(_currentRestaurant.Id);
                }
            }
        }



        private ObservableCollection<Restaurant> _restaurants = new();

        public ObservableCollection<Restaurant> Restaurants
        {
            get { return _restaurants; }
            set
            {
                if (_restaurants != value)
                {
                    _restaurants = value;
                    OnPropertyChanged(nameof(Restaurants));
                }
            }
        }

        private bool _currentPizzaAvailable;

        public bool CurrentPizzaAvailable
        {
            get { return _currentPizzaAvailable; }
            set
            {
                _currentPizzaAvailable = value;
                OnPropertyChanged(nameof(CurrentPizzaAvailable));            
            }
        }


        private ObservableCollection<PizzaLib.Pizza> _pizza;

        public ObservableCollection<PizzaLib.Pizza> Pizzas
        {
            get { return _pizza; }
            set
            {
                if (_pizza != value)
                {
                    _pizza = value;
                    OnPropertyChanged(nameof(Pizzas));
                }
            }
        }

        public async Task AddRestaurantAsync()
        {
            var r = new Restaurant
            {
                Name = RestaurantName
            };
            Context.Restaurants.Add(r);
            await Context.SaveChangesAsync();

            Restaurants.Add(r);

            RestaurantName = "";
        }

        public async Task GetRestaurantsAsync()
        {
            Restaurants = (await Context.Restaurants.ToListAsync()).ToObservableCollection();
        }

        public async Task GetPizzaAsync(int restaurantId)
        {
            var pizzas = await Context.Pizzas
                .Where(x => x.RestaurantId == restaurantId)
                .ToListAsync();

            Pizzas = pizzas.ToObservableCollection();
        }
    }
}
