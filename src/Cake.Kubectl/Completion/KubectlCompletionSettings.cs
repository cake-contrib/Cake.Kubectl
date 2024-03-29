using System.Runtime.CompilerServices;

namespace Cake.Kubectl
{
	/// <summary>
	/// Output shell completion code for the specified shell (bash, zsh, fish, or powershell). The shell code must be evaluated to provide interactive completion of kubectl commands.  This can be done by sourcing it from the .bash_profile.
	///
	/// 
	///  Detailed instructions on how to do this are available here:
	/// 
	///   for macOS:
	///   https://kubernetes.io/docs/tasks/tools/install-kubectl-macos/#enable-shell-autocompletion
	/// 
	///   for linux:
	///   https://kubernetes.io/docs/tasks/tools/install-kubectl-linux/#enable-shell-autocompletion
	/// 
	///   for windows:
	///   https://kubernetes.io/docs/tasks/tools/install-kubectl-windows/#enable-shell-autocompletion
	/// 
	///  Note for zsh users: [1] zsh completions are only supported in versions of zsh &gt;= 5.2.
	/// </summary>
	/// <example>
	///   # Installing bash completion on macOS using homebrew
	///   ## If running Bash 3.2 included with macOS
	///   brew install bash-completion
	///   ## or, if running Bash 4.1+
	///   brew install bash-completion@2
	///   ## If kubectl is installed via homebrew, this should start working immediately
	///   ## If you've installed via other means, you may need add the completion to your completion directory
	///   kubectl completion bash &gt; $(brew --prefix)/etc/bash_completion.d/kubectl
	/// 
	/// 
	///   # Installing bash completion on Linux
	///   ## If bash-completion is not installed on Linux, install the 'bash-completion' package
	///   ## via your distribution's package manager.
	///   ## Load the kubectl completion code for bash into the current shell
	///   source &lt;(kubectl completion bash)
	///   ## Write bash completion code to a file and source it from .bash_profile
	///   kubectl completion bash &gt; ~/.kube/completion.bash.inc
	///   printf "
	///   # Kubectl shell completion
	///   source '$HOME/.kube/completion.bash.inc'
	///   " &gt;&gt; $HOME/.bash_profile
	///   source $HOME/.bash_profile
	/// 
	///   # Load the kubectl completion code for zsh[1] into the current shell
	///   source &lt;(kubectl completion zsh)
	///   # Set the kubectl completion code for zsh[1] to autoload on startup
	///   kubectl completion zsh &gt; "${fpath[1]}/_kubectl"
	/// 
	/// 
	///   # Load the kubectl completion code for fish[2] into the current shell
	///   kubectl completion fish | source
	///   # To load completions for each session, execute once:
	///   kubectl completion fish &gt; ~/.config/fish/completions/kubectl.fish
	/// 
	///   # Load the kubectl completion code for powershell into the current shell
	///   kubectl completion powershell | Out-String | Invoke-Expression
	///   # Set kubectl completion code for powershell to run on startup
	///   ## Save completion code to a script and execute in the profile
	///   kubectl completion powershell &gt; $HOME\.kube\completion.ps1
	///   Add-Content $PROFILE "$HOME\.kube\completion.ps1"
	///   ## Execute completion code in the profile
	///   Add-Content $PROFILE "if (Get-Command kubectl -ErrorAction SilentlyContinue) {
	///   kubectl completion powershell | Out-String | Invoke-Expression
	///   }"
	///   ## Add completion code directly to the $PROFILE script
	///   kubectl completion powershell &gt;&gt; $PROFILE
	/// </example>
	[CompilerGenerated]
	public sealed class KubectlCompletionSettings : AutoToolSettings
	{
	}
}
