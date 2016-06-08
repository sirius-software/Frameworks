using Bridge.Html5;

namespace Bridge.WebGL
{
    /// <summary>
    /// WebGLRenderingContext objects expose the WebGLRenderingContext interface, the principal interface in WebGL which provides special properties and methods to manipulate the 3D content rendered in an HTML canvas element.
    /// The docs sources are:
    ///     https://www.khronos.org/registry/webgl/specs/1.0/
    ///     https://www.khronos.org/opengles/sdk/docs/man/
    ///     https://developer.mozilla.org/ru/docs/Web/API/WebGLRenderingContext
    ///     https://msdn.microsoft.com/en-us/library/ie/dn621085%28v=vs.85%29.aspx
    /// </summary>
    [External]
    public partial class WebGLRenderingContext : IWebGLRenderingContext
    {
        /// <summary>
        /// The Canvas element associated with this context. May be null!
        /// </summary>
        public readonly HTMLCanvasElement Canvas;

        /// <summary>
        /// Width of the current drawing buffer. Should match the width of the canvas element associated with this context.
        /// </summary>
        public readonly int DrawingBufferWidth;

        /// <summary>
        /// Height of the current drawing buffer. Should match the height of the canvas element associated with this context.
        /// </summary>
        public readonly int DrawingBufferHeight;
    }
}