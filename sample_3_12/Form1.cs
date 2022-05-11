using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_3_12 {
  public partial class Form1 : DevExpress.XtraEditors.XtraForm {
    public Form1() {
      InitializeComponent();
      // Handling the QueryControl event that will populate all automatically generated Documents
      this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

      var action = new DelegateAction(
        () => UserLookAndFeel.Default.ActiveSkinName == SkinStyle.Springtime,
        () => UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, SkinSvgPalette.Bezier.TwentyGold));
      var reverseAction = new DelegateAction(
        () => UserLookAndFeel.Default.ActiveSkinName == SkinStyle.Bezier,
        () => UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Springtime));

      action.Caption = "Bezier Skin";
      action.Type = ActionType.Context;
      action.Edge = ActionEdge.Left;
      action.Behavior = ActionBehavior.Default;

      reverseAction.Caption = "Springtime Skin";
      reverseAction.Type = ActionType.Context;
      reverseAction.Edge = ActionEdge.Left;
      reverseAction.Behavior = ActionBehavior.Default;

      windowsUIView1.ContentContainerActions.Add(action);
      windowsUIView1.ContentContainerActions.Add(reverseAction);

      // For a specific container:
      // tileContainer1.Actions.Add(action);
    }

    // Assigning a required content for each auto generated Document
    void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {

      if (e.Document == richEditUserControlDocument)
        e.Control = new sample_3_12.RichEditUserControl();
      if (e.Document == gridUserControlDocument)
        e.Control = new sample_3_12.GridUserControl();
      if (e.Control == null)
        e.Control = new System.Windows.Forms.Control();
    }
  }
}
