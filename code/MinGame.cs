using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{

	/// <summary>
	/// An absolutely minimal GameMode with no custom code.
	/// </summary>
    public partial class MinGame : BaseGameManager
    {
		/* BaseGameManager says to inherit from Sandbox.Game instead, but Game is a static class,
		* so I assume that advice is incorrect now. Most likely, the replacement for Sandbox.Game is 
		* the GameManager in the Base project, but I'd rather this minimal game not have any 
		* dependencies on the Base project, so I'm just gonna inherit from BaseGameManager anyway.
		*/

		public override void Shutdown()
		{
			// NOP here to satisfy the requirements of the abstract class.
			// The Base project GameManager did nothing but clean up a singleton here.
		}
	}
}
