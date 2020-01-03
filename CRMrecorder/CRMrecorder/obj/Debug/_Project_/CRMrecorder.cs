using CRMrecorder_Windows_Application1 = CRMrecorder.Windows_Application1;

using CRMrecorder_Automation1 = CRMrecorder.Automation1;

using System;

namespace CRMrecorder.Project
{
// Project-8D7637AAAFC7FE4
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D7637AAAFC7FE4")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class CRMrecorder : OpenSpan.Runtime.RuntimeProject
{
	
	public CRMrecorder() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMrecorder_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMrecorder(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMrecorder_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMrecorder(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMrecorder_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMrecorder(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMrecorder_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private CRMrecorder(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMrecorder_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void CRMrecorder_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D7637AAAFC7FE4");
		this.mVersion = new System.Version("19.1.2.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.1");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WindowsAdapter-8D7637AB5167B4A
	public CRMrecorder_Windows_Application1 Windows_Application1
	{
		get
		{
			return ((CRMrecorder_Windows_Application1)(this["Windows_Application1"]));
		}
	}
	
	// Automator-8D7637AAAB00D8B
	public CRMrecorder_Automation1 Automation1
	{
		get
		{
			return ((CRMrecorder_Automation1)(this["Automation1"]));
		}
	}
}

}

