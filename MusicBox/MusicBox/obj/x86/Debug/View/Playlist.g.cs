﻿#pragma checksum "C:\Users\minh\source\repos\MusicBox\MusicBox\View\Playlist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E442F7CB47D588E272FE627E9CEDC80E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicBox.View
{
    partial class Playlist : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\Playlist.xaml line 11
                {
                    this.ParentStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // View\Playlist.xaml line 17
                {
                    this.Name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // View\Playlist.xaml line 18
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // View\Playlist.xaml line 19
                {
                    this.Singer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // View\Playlist.xaml line 20
                {
                    this.Author = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // View\Playlist.xaml line 21
                {
                    this.Link = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // View\Playlist.xaml line 22
                {
                    this.Thumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // View\Playlist.xaml line 24
                {
                    this.BtnReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnReset).Click += this.BtnReset_Click;
                }
                break;
            case 10: // View\Playlist.xaml line 25
                {
                    this.BtnSignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSignup).Click += this.SignUp;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

