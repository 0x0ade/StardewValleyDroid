#pragma warning disable CS0626

using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StardewValley
{
	class patch_KeyboardDispatcher
	{

		public extern void orig_set_Subscriber(IKeyboardSubscriber value);
		public void set_Subscriber(IKeyboardSubscriber value)
		{
			SDL.SDL_StopTextInput();
			orig_set_Subscriber(value);
			if (value != null)
				SDL.SDL_StartTextInput();
		}

	}
}
