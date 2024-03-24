using System.Windows.Forms;
using System;

namespace LinqDemo {

  public partial class BaseControl : UserControl {

    public BaseControl() {
      InitializeComponent();
    }

    public BaseControl(string formName) {

      InitializeComponent();
      this.formName = formName;
    }

    private readonly string formName;
    private bool active = false;

    protected static CrmDataContext.CrmDataContext crmDataContext;

    internal virtual void OpenClick() {

      active = true;
    }
    internal virtual void CloseClick() {

      active = false;
    }
    
    internal string FormName {
      get {
        return formName;
      }
    }

    internal bool Active {
      get {
        return active;
      }
    }

    internal static CrmDataContext.CrmDataContext CrmDataContext {
      get {
        return crmDataContext;
      }
      set {
        crmDataContext = value;
      }
    }

    internal virtual void ControlsEnabled(bool state) {
    }

    internal virtual event EventHandler UpdateChanged;
  }
}
