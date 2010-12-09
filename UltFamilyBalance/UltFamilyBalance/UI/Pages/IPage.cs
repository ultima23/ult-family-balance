using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ult.FamilyBalance.UI.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPage
    {

        /// <summary>
        /// Page title
        /// </summary>
        string Title
        {
            get;
        }

        /// <summary>
        /// True id the page is corrently active
        /// </summary>
        bool Active
        {
            get;
        }

        /// <summary>
        /// True if the page can be hidden
        /// </summary>
        bool CanHide
        {
            get;
        }

        /// <summary>
        /// Page status
        /// </summary>
        PageStatus Status
        {
            get;
        }
        
        /// <summary>
        /// Control that rapresents the page
        /// </summary>
        Control Control
        {
            get;
        }

        /// <summary>
        ///  Initialize the current page
        /// </summary>
        void Init(params object[] args);

        /// <summary>
        /// Open the page with the provided size
        /// </summary>
        /// <param name="size"></param>
        void Open(Size size);

        /// <summary>
        /// Closes the page
        /// </summary>
        /// <returns></returns>
        void Close();

        /// <summary>
        /// Refresh page data
        /// </summary>
        void Refresh(params object[] args);

        /// <summary>
        /// Resize page to specified size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void UpdateSize(Size size);

    }

    public enum PageStatus
    {
        Unknown,
        Init,
        Ready,
        Active,
        Processing,
        Locked
    }

    public enum PageShowResult
    {
        Unknown,
        Success,
        Failed
    }

    public enum PageHideResult
    {
        Unknown,
        Success,
        Failed
    }

}
