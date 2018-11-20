public partial class AkBuildPreprocessor : UnityEditor.Build.IPreprocessBuild, UnityEditor.Build.IPostprocessBuild
{
	static partial void GetCustomPlatformName(ref string platformName, UnityEditor.BuildTarget target)
	{
		if(target == UnityEditor.BuildTarget.Android)
		{
			platformName = "Android_High";
		}
	}

}
