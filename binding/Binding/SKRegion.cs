//
// Bindings for SKRegion
//
// Author:
//   Vincent Nguyen
//
// Copyright 2016 Bluebeam Inc
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.0
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace SkiaSharp
{
	public class SKRegion : SKObject
	{
		[Preserve]
		internal SKRegion(IntPtr handle,  bool owns)
			: base (handle, owns)
		{
		}

		public SKRegion()
			: this (SkiaApi.sk_region_new(), true)
		{
		}

		public SKRegion(SKRegion region)
			: this(SkiaApi.sk_region_new2(region.Handle), true)
		{
		}

		public bool Contains(SKRegion src)
		{
			return SkiaApi.sk_region_contains(Handle, src.Handle); 
		}

		public bool Contains(int x, int y)
		{
			return SkiaApi.sk_region_contains2(Handle, x, y);
		}

		public bool Intersects(SKRegion region)
		{
			return SkiaApi.sk_region_intersects(Handle, region.Handle);
		}

		public bool Intersects(SKRectI rect)
		{
			return SkiaApi.sk_region_intersects(Handle, rect);
		}

		public bool Set(SKRegion region)
		{
			return SkiaApi.sk_region_set(Handle, region.Handle);
		}

		public bool SetRect(SKRectI rect)
		{
			return SkiaApi.sk_region_set_rect(Handle, ref rect); 
		}

		public bool SetPath(SKPath path)
		{
			return SkiaApi.sk_region_set_path(Handle, path.Handle); 
		}

		public bool Op(int left, int top, int right, int bottom, SKRegionOperation op)
		{
			return SkiaApi.sk_region_op(Handle, left, top, right, bottom, op);
		}

		public bool Op(SKRegion region, SKRegionOperation op)
		{
			return SkiaApi.sk_region_op2(Handle, region.Handle, op);
		}

		public SKRectI GetBounds()
		{
			return SkiaApi.sk_region_get_bounds(Handle);
		}
	}
}
