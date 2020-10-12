using Microsoft.AspNetCore.Components;
using SupplyChain.Client.HelperService;
using SupplyChain.Shared.Enum;
using Syncfusion.Blazor.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SupplyChain.Client.Shared
{
    public class ToastBase : ComponentBase, IDisposable
    {
        [Inject] ToastService ToastService { get; set; }
        protected SfToast ToastObj;
        protected string ToastTitle { get; set; }
        protected bool ShowButtons { get; set; } = false;
        protected bool Checked { get; set; } = true;
        protected ToastEasing ShowEasing { get; set; }
        protected ToastEasing HideEasing { get; set; }
        protected ToastEffect ShowEffect { get; set; }
        protected ToastEffect HideEffect { get; set; }
        protected string EasingValue { get; set; } = "ease";
        protected string AnimationValue { get; set; } = "SlideBottomIn";
        protected string HideEasingValue { get; set; } = "ease";
        protected string HideAnimationValue { get; set; } = "SlideBottomOut";
        protected string ToastContent { get; set; } = "You have created a Toast message";
        protected string TimeoutValue { get; set; } = "5000";
        protected int ToastTimeout { get; set; } = 5000;
        protected int ShowDuration { get; set; } = 400;
        protected int HideDuration { get; set; } = 400;
        protected bool ShowCloseBtn { get; set; } = false;
        protected bool ShowProgressBtn { get; set; } = false;
        protected bool ShowNewestOnTop { get; set; } = true;
        protected bool EnableButtons { get; set; } = false;

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }

        protected async override Task OnInitializedAsync()
        {
            ToastService.OnShow += ShowToast;
            ToastService.OnHide += HideToast;
            await InvokeAsync(StateHasChanged);
        }

        private async Task ShowToast(string message, TipoAlerta level)
        {
            //BuildToastSettings(level, message);
            //IsVisible = true;
            //StateHasChanged();

            //this.ToastTitle = this.TileObj.Value;
            //this.ToastContent = this.ContentObj.Value;
            //if (this.TileObj.Value == null && this.ContentObj.Value == null)
            //{
            //    this.ToastContent = "You have created a Toast message";
            //}
            this.ToastContent = "You have created a Toast message";
            this.ShowDuration = ShowDuration;
            this.HideDuration = HideDuration;
            this.ToastTimeout = int.Parse(TimeoutValue);
            this.StateHasChanged();
            await Task.Delay(100);
            await this.ToastObj.Show();
            await InvokeAsync(StateHasChanged);
        }

        private async Task HideToast()
        {
            IsVisible = false;
            await InvokeAsync(StateHasChanged);
        }

        private void BuildToastSettings(TipoAlerta level, string message)
        {
            switch (level)
            {
                case TipoAlerta.Info:
                    BackgroundCssClass = "bg-info";
                    IconCssClass = "info";
                    Heading = "Atención";
                    break;
                case TipoAlerta.Success:
                    BackgroundCssClass = "bg-success";
                    IconCssClass = "check";
                    Heading = "Guardado Correctamente";
                    break;
                case TipoAlerta.Warning:
                    BackgroundCssClass = "bg-warning";
                    IconCssClass = "exclamation";
                    Heading = "Warning";
                    break;
                case TipoAlerta.Error:
                    BackgroundCssClass = "bg-danger";
                    IconCssClass = "times";
                    Heading = "Error";
                    break;
            }

            Message = message;
        }

        public void Dispose()
        {
            ToastService.OnShow -= ShowToast;
        }
    }
}
