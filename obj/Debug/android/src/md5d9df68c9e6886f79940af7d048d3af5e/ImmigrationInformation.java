package md5d9df68c9e6886f79940af7d048d3af5e;


public class ImmigrationInformation
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DeakinInformation.ImmigrationInformation, DeakinInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImmigrationInformation.class, __md_methods);
	}


	public ImmigrationInformation () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImmigrationInformation.class)
			mono.android.TypeManager.Activate ("DeakinInformation.ImmigrationInformation, DeakinInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
