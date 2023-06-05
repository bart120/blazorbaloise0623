using Microsoft.AspNetCore.Components;
using ServicesLibrary.Models;

namespace CarsLibrary.Pages
{
    public partial class Detail:ComponentBase
    {
        protected Car? car;

        [Parameter]
        public int Id { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = "nom")]
        public string? Name { get; set; }

        /*public Detail(CarsService servCars, NavigationManager nav)
        {
            this.servCars = servCars;
            this.nav = nav;
        }*/

        protected override async Task OnInitializedAsync()
        {
            this.car = await servCars.GetById(Id);
        }

        protected async Task Back()
        {
            nav.NavigateTo("/cars/list");
        }
    }
}
