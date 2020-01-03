using System;

namespace CRMrecorder
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WindowsAdapter-8D7637AB5167B4A
[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D7637AB5167B4A")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class Windows_Application1 : OpenSpan.Adapters.Windows.WindowsAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D7637AB5167B4A\\DotNet20Factory-8D7637AC5065043")]
	public OpenSpan.Adapters.DotNet.DotNet20Factory DotNet20Factory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D7637AB5167B4A\\ActiveXFactory-8D7637AC53C4879")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D7637AB5167B4A\\Form-8D7637ACAA8408A")]
	public OpenSpan.Adapters.Controls.Form Login;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D7637AB5167B4A\\Control-8D7637ACAA37C3A")]
	public OpenSpan.Adapters.Controls.Control picLogo;
	
	private OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule virtualControlNativeControlNameMat1;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1;
	
	private OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule virtualControlContainerNativeWindo1;
	
	public Windows_Application1()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Application1));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		this.DotNet20Factory = new OpenSpan.Adapters.DotNet.DotNet20Factory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.Login = new OpenSpan.Adapters.Controls.Form();
		this.picLogo = new OpenSpan.Adapters.Controls.Control();
		this.virtualControlNativeControlNameMat1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule();
		this.windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.virtualControlContainerNativeWindo1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D7637AB5167B4A");
		// 
		// Set component Ids
		// 
		this.SetId(this.DotNet20Factory, new OpenSpan.Design.ComponentIdentity("DotNet20Factory-8D7637AC5065043"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC51A5D4C"));
		this.SetId(this.moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D7637AC5202038"));
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D7637AC53C4879"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC545D174"));
		this.SetId(this.Login, new OpenSpan.Design.ComponentIdentity("Form-8D7637ACAA8408A"));
		this.SetId(this.picLogo, new OpenSpan.Design.ComponentIdentity("Control-8D7637ACAA37C3A"));
		this.SetId(this.virtualControlNativeControlNameMat1, new OpenSpan.Design.ComponentIdentity("VirtualControlNativeControlNameMatchRule-8D7637ACABFE164"));
		this.SetId(this.windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D7637ACAAE042D"));
		this.SetId(this.virtualControlContainerNativeWindo1, new OpenSpan.Design.ComponentIdentity("VirtualControlContainerNativeWindowNameMatchRule-8D7637ACAB78B13"));
		// 
		// Windows_Application1
		// 
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_Windows_Application1_1_");
		// 
		// DotNet20Factory
		// 
		this.DotNet20Factory.Extender = null;
		this.DotNet20Factory.FactoryName = null;
		this.DotNet20Factory.ForwardObjectExplorerEvent = true;
		this.DotNet20Factory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule1
		// 
		textmatchdata1.Text = "mscorwks.dll";
		this.moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// moduleVersionMatchRule1
		// 
		textmatchdata2.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata2.Text = "2.0.*.*";
		this.moduleVersionMatchRule1.Text = textmatchdata2;
		this.DotNet20Factory.MatchRules.Add(this.moduleNameMatchRule1);
		this.DotNet20Factory.MatchRules.Add(this.moduleVersionMatchRule1);
		this.DotNet20Factory.Name = "DotNet20Factory";
		this.DotNet20Factory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.DotNet20Factory.UseKeys = true;
		// 
		// ActiveXFactory
		// 
		this.ActiveXFactory.Extender = null;
		this.ActiveXFactory.FactoryName = null;
		this.ActiveXFactory.ForwardObjectExplorerEvent = true;
		this.ActiveXFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule2
		// 
		textmatchdata3.Text = "ole32.dll";
		this.moduleNameMatchRule2.Text = textmatchdata3;
		this.ActiveXFactory.MatchRules.Add(this.moduleNameMatchRule2);
		this.ActiveXFactory.Name = "ActiveXFactory";
		this.ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.ActiveXFactory.UseKeys = true;
		// 
		// Login
		// 
		// 
		// picLogo
		// 
		this.picLogo.Extender = null;
		this.picLogo.ExtensibleTypeName = "System.Windows.Forms.PictureBox, System.Windows.Forms";
		this.picLogo.ForwardObjectExplorerEvent = true;
		this.picLogo.MatchingIndex = 7;
		// 
		// virtualControlNativeControlNameMat1
		// 
		textmatchdata4.Text = "picLogo";
		this.virtualControlNativeControlNameMat1.NativeControlName = textmatchdata4;
		this.picLogo.MatchRules.Add(this.virtualControlNativeControlNameMat1);
		this.picLogo.Name = "picLogo";
		this.picLogo.TargetTypeString = _resources_.GetString("_Windows_Application1_2_");
		this.Login.Controls.Add(this.picLogo);
		this.Login.Extender = null;
		this.Login.ExtensibleTypeName = null;
		this.Login.ForwardObjectExplorerEvent = true;
		this.Login.MatchingIndex = 3;
		// 
		// windowTextMatchRule1
		// 
		textmatchdata5.Text = "Login";
		this.windowTextMatchRule1.Text = textmatchdata5;
		// 
		// virtualControlContainerNativeWindo1
		// 
		textmatchdata6.Text = "WindowsForms10.Window.8.app.0.378734a";
		this.virtualControlContainerNativeWindo1.VirtualWindowName = textmatchdata6;
		this.Login.MatchRules.Add(this.windowTextMatchRule1);
		this.Login.MatchRules.Add(this.virtualControlContainerNativeWindo1);
		this.Login.Name = "Login";
		this.Login.TargetTypeString = _resources_.GetString("_Windows_Application1_3_");
		this.Controls.Add(this.DotNet20Factory);
		this.Controls.Add(this.ActiveXFactory);
		this.Controls.Add(this.Login);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "Windows_Application1";
		this.Name = "Windows_Application1";
		this.Path = "C:\\Program Files (x86)\\Pegasystems\\CRM Setup\\CRM.exe";
		this.ReasonAdapterNotReady = null;
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		this.WorkingDirectory = "C:\\Program Files (x86)\\Pegasystems\\CRM Setup";
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.DotNet20Factory);
		this.Components.Add(this.moduleNameMatchRule1);
		this.Components.Add(this.moduleVersionMatchRule1);
		this.Components.Add(this.ActiveXFactory);
		this.Components.Add(this.moduleNameMatchRule2);
		this.Components.Add(this.Login);
		this.Components.Add(this.picLogo);
		this.Components.Add(this.virtualControlNativeControlNameMat1);
		this.Components.Add(this.windowTextMatchRule1);
		this.Components.Add(this.virtualControlContainerNativeWindo1);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Adapters.DotNet.DotNet20Factory Create_DotNet20Factory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.DotNet.DotNet20Factory DotNet20Factory = new OpenSpan.Adapters.DotNet.DotNet20Factory();
		this.SetId(DotNet20Factory, new OpenSpan.Design.ComponentIdentity("DotNet20Factory-8D7637AC5065043"));
		DotNet20Factory.Extender = null;
		DotNet20Factory.FactoryName = null;
		DotNet20Factory.ForwardObjectExplorerEvent = true;
		DotNet20Factory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
		moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mscorwks.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1;
		moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		// 
		// moduleVersionMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata2.Text = "2.0.*.*";
		moduleVersionMatchRule1.Text = textmatchdata2;
		DotNet20Factory.MatchRules.Add(moduleNameMatchRule1);
		DotNet20Factory.MatchRules.Add(moduleVersionMatchRule1);
		DotNet20Factory.Name = "DotNet20Factory";
		DotNet20Factory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		DotNet20Factory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC51A5D4C"));
		this.SetId(moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D7637AC5202038"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule1);
		components.Add(moduleVersionMatchRule1);
		// 
		// Result
		// 
		return DotNet20Factory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC51A5D4C"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mscorwks.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule Create_moduleVersionMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		this.SetId(moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D7637AC5202038"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata1.Text = "2.0.*.*";
		moduleVersionMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleVersionMatchRule1;
	}
	
	internal OpenSpan.Adapters.ActiveX.ActiveXFactory Create_ActiveXFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D7637AC53C4879"));
		ActiveXFactory.Extender = null;
		ActiveXFactory.FactoryName = null;
		ActiveXFactory.ForwardObjectExplorerEvent = true;
		ActiveXFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
		moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		ActiveXFactory.MatchRules.Add(moduleNameMatchRule2);
		ActiveXFactory.Name = "ActiveXFactory";
		ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		ActiveXFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC545D174"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule2);
		// 
		// Result
		// 
		return ActiveXFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D7637AC545D174"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule2;
	}
	
	internal OpenSpan.Adapters.Controls.Form Create_Login(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Application1));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Form Login = new OpenSpan.Adapters.Controls.Form();
		this.SetId(Login, new OpenSpan.Design.ComponentIdentity("Form-8D7637ACAA8408A"));
		OpenSpan.Adapters.Controls.Control picLogo;
		picLogo = new OpenSpan.Adapters.Controls.Control();
		// 
		// picLogo
		// 
		picLogo.Extender = null;
		picLogo.ExtensibleTypeName = "System.Windows.Forms.PictureBox, System.Windows.Forms";
		picLogo.ForwardObjectExplorerEvent = true;
		picLogo.MatchingIndex = 7;
		OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule virtualControlNativeControlNameMat1;
		virtualControlNativeControlNameMat1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule();
		// 
		// virtualControlNativeControlNameMat1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "picLogo";
		virtualControlNativeControlNameMat1.NativeControlName = textmatchdata1;
		picLogo.MatchRules.Add(virtualControlNativeControlNameMat1);
		picLogo.Name = "picLogo";
		picLogo.TargetTypeString = _resources_.GetString("_Windows_Application1_2_");
		Login.Controls.Add(picLogo);
		Login.Extender = null;
		Login.ExtensibleTypeName = null;
		Login.ForwardObjectExplorerEvent = true;
		Login.MatchingIndex = 3;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1;
		windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "Login";
		windowTextMatchRule1.Text = textmatchdata2;
		OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule virtualControlContainerNativeWindo1;
		virtualControlContainerNativeWindo1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule();
		// 
		// virtualControlContainerNativeWindo1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "WindowsForms10.Window.8.app.0.378734a";
		virtualControlContainerNativeWindo1.VirtualWindowName = textmatchdata3;
		Login.MatchRules.Add(windowTextMatchRule1);
		Login.MatchRules.Add(virtualControlContainerNativeWindo1);
		Login.Name = "Login";
		Login.TargetTypeString = _resources_.GetString("_Windows_Application1_3_");
		// 
		// Set designComp Ids
		// 
		this.SetId(picLogo, new OpenSpan.Design.ComponentIdentity("Control-8D7637ACAA37C3A"));
		this.SetId(virtualControlNativeControlNameMat1, new OpenSpan.Design.ComponentIdentity("VirtualControlNativeControlNameMatchRule-8D7637ACABFE164"));
		this.SetId(windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D7637ACAAE042D"));
		this.SetId(virtualControlContainerNativeWindo1, new OpenSpan.Design.ComponentIdentity("VirtualControlContainerNativeWindowNameMatchRule-8D7637ACAB78B13"));
		// 
		// Add components
		// 
		components.Add(picLogo);
		components.Add(virtualControlNativeControlNameMat1);
		components.Add(windowTextMatchRule1);
		components.Add(virtualControlContainerNativeWindo1);
		// 
		// Result
		// 
		return Login;
	}
	
	internal OpenSpan.Adapters.Controls.Control Create_picLogo(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Application1));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Control picLogo = new OpenSpan.Adapters.Controls.Control();
		this.SetId(picLogo, new OpenSpan.Design.ComponentIdentity("Control-8D7637ACAA37C3A"));
		picLogo.Extender = null;
		picLogo.ExtensibleTypeName = "System.Windows.Forms.PictureBox, System.Windows.Forms";
		picLogo.ForwardObjectExplorerEvent = true;
		picLogo.MatchingIndex = 7;
		OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule virtualControlNativeControlNameMat1;
		virtualControlNativeControlNameMat1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule();
		// 
		// virtualControlNativeControlNameMat1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "picLogo";
		virtualControlNativeControlNameMat1.NativeControlName = textmatchdata1;
		picLogo.MatchRules.Add(virtualControlNativeControlNameMat1);
		picLogo.Name = "picLogo";
		picLogo.TargetTypeString = _resources_.GetString("_Windows_Application1_2_");
		// 
		// Set designComp Ids
		// 
		this.SetId(virtualControlNativeControlNameMat1, new OpenSpan.Design.ComponentIdentity("VirtualControlNativeControlNameMatchRule-8D7637ACABFE164"));
		// 
		// Add components
		// 
		components.Add(virtualControlNativeControlNameMat1);
		// 
		// Result
		// 
		return picLogo;
	}
	
	internal OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Create_virtualControlNativeControlNameMat1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule virtualControlNativeControlNameMat1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule();
		this.SetId(virtualControlNativeControlNameMat1, new OpenSpan.Design.ComponentIdentity("VirtualControlNativeControlNameMatchRule-8D7637ACABFE164"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "picLogo";
		virtualControlNativeControlNameMat1.NativeControlName = textmatchdata1;
		// 
		// Result
		// 
		return virtualControlNativeControlNameMat1;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Create_windowTextMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.SetId(windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D7637ACAAE042D"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Login";
		windowTextMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return windowTextMatchRule1;
	}
	
	internal OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule Create_virtualControlContainerNativeWindo1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule virtualControlContainerNativeWindo1 = new OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule();
		this.SetId(virtualControlContainerNativeWindo1, new OpenSpan.Design.ComponentIdentity("VirtualControlContainerNativeWindowNameMatchRule-8D7637ACAB78B13"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "WindowsForms10.Window.8.app.0.378734a";
		virtualControlContainerNativeWindo1.VirtualWindowName = textmatchdata1;
		// 
		// Result
		// 
		return virtualControlContainerNativeWindo1;
	}
}

}

