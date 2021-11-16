using AnPhuocShop.Models;
using AnPhuocShop.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Pages
{
    public class EditAnPhuocBase:ComponentBase
    {
        public AnPhuoc AnPhuoc { get; set; } = new AnPhuoc();
        [Inject]
        public IAnPhuocService AnPhuocService { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public ILoaispSevice LoaispSevice { get; set; }
        public List<Loaisp> Loaisps { get; set; } = new List<Loaisp>();
        public string LoaispId { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int anphuocId);

            if (anphuocId != 0)
            {
                AnPhuoc = await AnPhuocService.GetAnPhuoc(int.Parse(Id));
            }
            else
            {
                AnPhuoc = new AnPhuoc
                {
                };
            }
            Loaisps = (await LoaispSevice.GetLoaisps()).ToList();
        }

        protected async Task HandleValidSubmit()
        {
            AnPhuoc result = null;
            if (AnPhuoc.AnPhuocId != 0)
            {
                result = await AnPhuocService.UpdateAnPhuoc(AnPhuoc);
            }
            else
            {
                result = await AnPhuocService.CreateAnPhuoc(AnPhuoc);
            }
            if(result != null)
            {
                NavigationManager.NavigateTo("/");
            }    
        }
        protected async Task Delete_Click()
        {
            await AnPhuocService.DeleteAnPhuoc(AnPhuoc.AnPhuocId);
            NavigationManager.NavigateTo("/");
        }
    }
}
