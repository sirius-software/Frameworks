using Bridge;

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
    public partial class WebGLRenderingContext
    {
        #region Buffer mask constants

        /// <summary>
        /// Passed to clear() to clear the current depth buffer
        /// </summary>
        [Convention]
        public readonly int DEPTH_BUFFER_BIT;

        /// <summary>
        /// Passed to clear() to clear the current stencil buffer
        /// </summary>
        [Convention]
        public readonly int STENCIL_BUFFER_BIT;

        /// <summary>
        /// Passed to clear() to clear the current color buffer
        /// </summary>
        [Convention]
        public readonly int COLOR_BUFFER_BIT;

        #endregion

        #region Primitives constants

        /// <summary>
        /// Draws a single dot per vertex. For example, 12 vertices produce 12 dots.
        /// </summary>
        [Convention]
        public readonly int POINTS;

        /// <summary>
        /// Draws a line between a pair of vertices. For example, 12 vertices produce 6 separate lines.
        /// </summary>
        [Convention]
        public readonly int LINES;

        /// <summary>
        /// Similar to gl.LINE_STRIP, but connects the last vertex back to the first. For example, 12 vertices produce 12 straight lines. Not as efficient as gl.LINES, and incurs a conversion cost.
        /// </summary>
        [Convention]
        public readonly int LINE_LOOP;

        /// <summary>
        /// Draws a line to the next by a straight line. For example, 12 vertices produce 11 lines connected end to end.
        /// </summary>
        [Convention]
        public readonly int LINE_STRIP;

        /// <summary>
        /// Draws a triangle for each group of three consecutive vertices. For example, 12 vertices create 4 separate triangles.
        /// </summary>
        [Convention]
        public readonly int TRIANGLES;

        /// <summary>
        /// Creates a strip of triangles where each additional vertex creates an additional triangle once the first three vertices have been drawn. For example, 12 vertices create 10 triangles.
        /// </summary>
        [Convention]
        public readonly int TRIANGLE_STRIP;

        /// <summary>
        /// Similar to gl.TRIANGLE_STRIP, but creates a fan shaped output. For example 12 vertices create 10 triangles. May incur a conversion cost.
        /// </summary>
        [Convention]
        public readonly int TRIANGLE_FAN;

        #endregion

        #region blendFunc sfactor and dfactor constants

        /// <summary>
        /// The destination depends on the method that the constant is passed to.
        /// </summary>
        [Convention]
        public readonly int ZERO;

        /// <summary>
        /// Factor: 1 1 1 1
        /// Multiplies all colors by 1.
        /// </summary>
        [Convention]
        public readonly int ONE;

        /// <summary>
        /// Factror: Rs Gs Bs As
        /// Multiply by source color value.
        /// </summary>
        [Convention]
        public readonly int SRC_COLOR;

        /// <summary>
        /// Factor: (1-Rs) (1-Gs) (1-Bs) (1-As)
        /// Multiply by 1 minus each color value.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_SRC_COLOR;

        /// <summary>
        /// Factor: Rd Gd Bd Ad
        /// Multiply by destination color value.
        /// </summary>
        [Convention]
        public readonly int DST_COLOR;

        /// <summary>
        /// Factor: (1-Rd) (1-Gd) (1-Bd) (1-Ad)
        /// Multiply by 1 minus each color value.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_DST_COLOR;

        /// <summary>
        /// Factor: As As As As
        /// Multiply all colors by source alpha value.
        /// </summary>
        [Convention]
        public readonly int SRC_ALPHA;

        /// <summary>
        /// Factor: (1-As) (1-As) (1-As) (1-As)
        /// Multiply all colors by 1 minus source alpha value.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_SRC_ALPHA;

        /// <summary>
        /// Factor: Ad Ad Ad Ad
        /// Multiply all colors by source alpha value.
        /// </summary>
        [Convention]
        public readonly int DST_ALPHA;

        /// <summary>
        /// Factor: (1-Ad) (1-Ad) (1-Ad) (1-Ad)
        /// Multiply all colors by 1 minus destination alpha value.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_DST_ALPHA;

        /// <summary>
        /// Factor: min(As, Ad) min(As,Ad) min(As,Ad) 1
        /// Multiply by the smaller of either source or destination alpha value.
        /// </summary>
        [Convention]
        public readonly int SRC_ALPHA_SATURATE;

        #endregion

        #region depthFunc and stencilFunc constants

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will never pass. i.e. nothing will be drawn.
        /// </summary>
        [Convention]
        public readonly int NEVER;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is less than the stored value.
        /// </summary>
        [Convention]
        public readonly int ALWAYS;

        /// <summary>
        ///      Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is less than the stored value.
        /// </summary>
        [Convention]
        public readonly int LESS;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is equals to the stored value.
        /// </summary>
        [Convention]
        public readonly int EQUAL;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is less than or equal to the stored value.
        /// </summary>
        [Convention]
        public readonly int LEQUAL;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is greater than the stored value.
        /// </summary>
        [Convention]
        public readonly int GREATER;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is greater than or equal to the stored value.
        /// </summary>
        [Convention]
        public readonly int GEQUAL;

        /// <summary>
        /// Passed to depthFunction() or stencilFunction() to specify depth or stencil tests will pass if the new depth value is not equal to the stored value.
        /// </summary>
        [Convention]
        public readonly int NOTEQUAL;

        #endregion

        #region BlendEquationSeparate constants

        [Convention]
        public readonly int FUNC_ADD;

        /// <summary>
        /// Passed to blendFuncSeparate to specify an addition blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_EQUATION;

        /// <summary>
        /// Passed to getParameter to get the current rgb blend function. Same as BLEND_EQUATION
        /// </summary>
        [Convention]
        public readonly int BLEND_EQUATION_RGB;

        /// <summary>
        /// Passed to getParameter to get the current alpha blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_EQUATION_ALPHA;

        #endregion

        #region BlendSubtract constants

        /// <summary>
        /// Passed to bendFuncSeparate to specify a subtraction blend function (source - destination).
        /// </summary>
        [Convention]
        public readonly int FUNC_SUBTRACT;

        /// <summary>
        /// Passed to bendFuncSeparate to specify a reverse subtraction blend function (destination - source).
        /// </summary>
        [Convention]
        public readonly int FUNC_REVERSE_SUBTRACT;

        #endregion

        #region Separate Blend Functions

        /// <summary>
        /// Passed to getParameter to get the current destination rgb blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_DST_RGB;

        /// <summary>
        /// Passed to getParameter to get the current destination rgb blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_SRC_RGB;

        /// <summary>
        /// Passed to getParameter to get the current destination alpha blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_DST_ALPHA;

        /// <summary>
        /// Passed to getParameter to get the current source alpha blend function.
        /// </summary>
        [Convention]
        public readonly int BLEND_SRC_ALPHA;

        /// <summary>
        /// Passed to blendFunc to specify a constant color blend function.
        /// </summary>
        [Convention]
        public readonly int CONSTANT_COLOR;

        /// <summary>
        /// Passed to blendFunc to specify one minus a constant color blend function.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_CONSTANT_COLOR;

        /// <summary>
        /// Passed to blendFunc to specify a constant alpha blend function.
        /// </summary>
        [Convention]
        public readonly int CONSTANT_ALPHA;

        /// <summary>
        /// Passed to blendFunc to specify one minus a constant alpha blend function.
        /// </summary>
        [Convention]
        public readonly int ONE_MINUS_CONSTANT_ALPHA;

        /// <summary>
        /// Passed to getParameter to return a the current blend color.
        /// </summary>
        [Convention]
        public readonly int BLEND_COLOR;

        #endregion

        #region Buffer Objects

        /// <summary>
        /// Passed to bindBuffer or bufferData to specify the type of buffer being used.
        /// </summary>
        [Convention]
        public readonly int ARRAY_BUFFER;

        /// <summary>
        /// Passed to bindBuffer or bufferData to specify the type of buffer being used.
        /// </summary>
        [Convention]
        public readonly int ELEMENT_ARRAY_BUFFER;

        /// <summary>
        /// Passed to getVertexAttrib to recall a buffer.
        /// </summary>
        [Convention]
        public readonly int ARRAY_BUFFER_BINDING;

        /// <summary>
        /// Passed to getParameter to get the current element array buffer.
        /// </summary>
        [Convention]
        public readonly int ELEMENT_ARRAY_BUFFER_BINDING;

        /// <summary>
        /// Passed to bufferData as a hint about whether the contents of the buffer are likely to not be used often.
        /// </summary>
        [Convention]
        public readonly int STREAM_DRAW;

        /// <summary>
        /// Passed to bufferData as a hint about whether the contents of the buffer are likely to be used often and not change often.
        /// </summary>
        [Convention]
        public readonly int STATIC_DRAW;

        /// <summary>
        /// Passed to bufferData as a hint about whether the contents of the buffer are likely to be used often and change often.
        /// </summary>
        [Convention]
        public readonly int DYNAMIC_DRAW;

        /// <summary>
        /// Passed to getBufferParameter to get a buffer's size.
        /// </summary>
        [Convention]
        public readonly int BUFFER_SIZE;

        /// <summary>
        /// Passed to getBufferParameter to get the hint for the buffer passed in when it was created.
        /// </summary>
        [Convention]
        public readonly int BUFFER_USAGE;

        /// <summary>
        /// Passed to getVertexAttrib to read back the current vertex attribute.
        /// </summary>
        [Convention]
        public readonly int CURRENT_VERTEX_ATTRIB;

        #endregion

        #region CullFaceMode

        /// <summary>
        /// Passed to cullFace to specify that only front faces should be drawn.
        /// </summary>
        [Convention]
        public readonly int FRONT;

        /// <summary>
        /// Passed to cullFace to specify that only back faces should be drawn.
        /// </summary>
        [Convention]
        public readonly int BACK;

        /// <summary>
        /// Passed to cullFace to specify that front and back faces should be drawn.
        /// </summary>
        [Convention]
        public readonly int FRONT_AND_BACK;

        #endregion

        #region EnableCap TEXTURE_2D

        /// <summary>
        /// Passed to enable()/disable() to turn on/off culling. Can also be used with getParameter to find the current culling method.
        /// </summary>
        [Convention]
        public readonly int CULL_FACE;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off blending. Can also be used with getParameter() to find the current blending method.
        /// </summary>
        [Convention]
        public readonly int BLEND;

        /// <summary>
        ///      Passed to enable()/disable() to turn on/off dithering. Can also be used with getParameter to find the current dithering method.
        /// </summary>
        [Convention]
        public readonly int DITHER;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the stencil test. Can also be used with getParameter to query the stencil test.
        /// </summary>
        [Convention]
        public readonly int STENCIL_TEST;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the depth test. Can also be used with getParameter to query the depth test.
        /// </summary>
        [Convention]
        public readonly int DEPTH_TEST;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the scissor test. Can also be used with getParameter to query the scissor test.
        /// </summary>
        [Convention]
        public readonly int SCISSOR_TEST;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the polygon offset. Useful for rendering hidden-line images, decals, and or solids with highlighted edges.
        /// </summary>
        [Convention]
        public readonly int POLYGON_OFFSET_FILL;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the alpha to coverage. Used in multi-sampling alpha channels.
        /// </summary>
        [Convention]
        public readonly int SAMPLE_ALPHA_TO_COVERAGE;

        /// <summary>
        /// Passed to enable()/disable() to turn on/off the sample coverage. Used in multi-sampling.
        /// </summary>
        [Convention]
        public readonly int SAMPLE_COVERAGE;

        #endregion

        #region ErrorCode

        /// <summary>
        /// No error has been recorded. This can occur if getError has been called previously, and continues until the error has been corrected.
        /// </summary>
        [Convention]
        public readonly int NO_ERROR;

        /// <summary>
        /// An unacceptable value for an enumerated argument was specified.
        /// </summary>
        [Convention]
        public readonly int INVALID_ENUM;

        /// <summary>
        /// A number that was passed is out of range. The unacceptable value is ignored.
        /// </summary>
        [Convention]
        public readonly int INVALID_VALUE;

        /// <summary>
        /// The specified operation isn't allowed for the current state. The command is ignored.
        /// </summary>
        [Convention]
        public readonly int INVALID_OPERATION;

        /// <summary>
        /// The command requires more memory than is available. After this error is reported, the state of the WebGL context is undefined except for error flags.
        /// </summary>
        [Convention]
        public readonly int OUT_OF_MEMORY;

        #endregion

        #region FrontFaceDirection

        /// <summary>
        /// Passed to frontFace to specify the front face of a polygon is drawn inthe clockwise direction
        /// </summary>
        [Convention]
        public readonly int CW;

        /// <summary>
        /// Passed to frontFace to specify the front face of a polygon is drawn inthe counter clockwise direction
        /// </summary>
        [Convention]
        public readonly int CCW;

        #endregion

        #region GetPName

        /// <summary>
        /// Passed to getParameter to get the current lineWidth (set by the lineWidth method).
        /// </summary>
        [Convention]
        public readonly int LINE_WIDTH;

        /// <summary>
        /// Passed to getParamter to get the current size of a point drawn with gl.POINTS.
        /// </summary>
        [Convention]
        public readonly int ALIASED_POINT_SIZE_RANGE;

        /// <summary>
        /// Passed to getParamter to get the range of available widths for a line. Returns a length-2 array with the lo value at 0, and hight at 1.
        /// </summary>
        [Convention]
        public readonly int ALIASED_LINE_WIDTH_RANGE;

        /// <summary>
        /// Passed to getParameter to get the current value of cullFace. Should return FRONT, BACK, or FRONT_AND_BACK
        /// </summary>
        [Convention]
        public readonly int CULL_FACE_MODE;

        /// <summary>
        /// Passed to getParameter to determine the current value of frontFace. Should return CW or CCW.
        /// </summary>
        [Convention]
        public readonly int FRONT_FACE;

        /// <summary>
        /// Passed to getParameter to return a length-2 array of floats giving the current depth range.
        /// </summary>
        [Convention]
        public readonly int DEPTH_RANGE;

        /// <summary>
        /// Passed to getParameter to determine if the depth write mask is enabled.
        /// </summary>
        [Convention]
        public readonly int DEPTH_WRITEMASK;

        /// <summary>
        /// Passed to getParameter to determine the current depth clear value.
        /// </summary>
        [Convention]
        public readonly int DEPTH_CLEAR_VALUE;

        /// <summary>
        /// Passed to getParamter to get the current depth function. Returns NEVER, ALWAYS, LESS, EQUAL, LEQUAL, GREATER, GEQUAL, or NOTEQUAL.
        /// </summary>
        [Convention]
        public readonly int DEPTH_FUNC;

        /// <summary>
        /// Passed to getParamter to get the value the stencil will be cleared to.
        /// </summary>
        [Convention]
        public readonly int STENCIL_CLEAR_VALUE;

        /// <summary>
        /// Passed to getParameter to get the current stencil function. Returns NEVER, ALWAYS, LESS, EQUAL, LEQUAL, GREATER, GEQUAL, or NOTEQUAL.
        /// </summary>
        [Convention]
        public readonly int STENCIL_FUNC;

        /// <summary>
        /// Passed to getParameter to get the current stencil fail function. Should return KEEP, REPLACE, INCR, DECR, INVERT, INCR_WRAP, or DECR_WRAP.
        /// </summary>
        [Convention]
        public readonly int STENCIL_FAIL;

        /// <summary>
        /// Passed to getParamter to get the current stencil fail function should the depth buffer test fail. Should return KEEP, REPLACE, INCR, DECR, INVERT, INCR_WRAP, or DECR_WRAP.
        /// </summary>
        [Convention]
        public readonly int STENCIL_PASS_DEPTH_FAIL;

        /// <summary>
        /// Passed to getParameter to get the current stencil fail function should the depth buffer test pass. Should return KEEP, REPLACE, INCR, DECR, INVERT, INCR_WRAP, or DECR_WRAP.
        /// </summary>
        [Convention]
        public readonly int STENCIL_PASS_DEPTH_PASS;

        /// <summary>
        /// Passed to getParameter to get the reference value used for stencil tests.
        /// </summary>
        [Convention]
        public readonly int STENCIL_REF;

        /// <summary>
        /// Passed to getParameter to get the mask that is used to mask both the stencil reference value and the stencil buffer value before they are compared for front-facing polygons and non-polygons.
        /// The initial value is all 1's. See glStencilFunc and glStencilFuncSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_VALUE_MASK;

        /// <summary>
        /// Passed to getParameter to get the mask that controls writing of the stencil bitplanes for front-facing polygons and non-polygons.
        /// The initial value is all 1's. See glStencilMask and glStencilMaskSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_WRITEMASK;

        /// <summary>
        /// Passed to getParameter to get
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_FUNC;

        /// <summary>
        /// Passed to getParameter to get a symbolic constant indicating what function is used for back-facing polygons to compare the stencil reference value with the stencil buffer value.
        /// The initial value is GL_ALWAYS. See glStencilFuncSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_FAIL;

        /// <summary>
        /// Passed to getParameter to get a symbolic constant indicating what action is taken for back-facing polygons when the stencil test passes, but the depth test fails.
        /// The initial value is GL_KEEP. See glStencilOpSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_PASS_DEPTH_FAIL;

        /// <summary>
        /// Passed to getParameter to get a symbolic constant indicating what action is taken for back-facing polygons when the stencil test passes and the depth test passes.
        /// The initial value is GL_KEEP. See glStencilOpSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_PASS_DEPTH_PASS;

        /// <summary>
        /// Passed to getParameter to get the reference value that is compared with the contents of the stencil buffer for back-facing polygons.
        /// The initial value is 0. See glStencilFuncSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_REF;

        /// <summary>
        /// Passed to getParameter to get the mask that is used for back-facing polygons to mask both the stencil reference value and the stencil buffer value before they are compared.
        /// The initial value is all 1's. See glStencilFuncSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_VALUE_MASK;

        /// <summary>
        /// Passed to getParameter to get the mask that controls writing of the stencil bitplanes for back-facing polygons.
        /// The initial value is all 1's. See glStencilMaskSeparate.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BACK_WRITEMASK;

        /// <summary>
        /// Passed to getParameter to get the viewport, i.e. the x and y window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates are both set to 0,
        /// and the width and height are set to the width and height of the window into which the GL will do its rendering.
        /// See glViewport.
        /// </summary>
        [Convention]
        public readonly int VIEWPORT;

        /// <summary>
        /// Passed to getParameter to get the scissor box, i.e. the x and y window coordinates of the scissor box, followed by its width and height.
        /// Initially the x and y window coordinates are both 0, and the width and height are set to the size of the window.
        /// See glScissor.
        /// </summary>
        [Convention]
        public readonly int SCISSOR_BOX;

        #endregion

        #region SCISSOR_TEST

        /// <summary>
        /// Passed to getParameter to get the red, green, blue, and alpha values used to clear the color buffers. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable integer value,
        /// and -1.0 returns the most negative representable integer value.
        /// The initial value is (0, 0, 0, 0).
        /// See glClearColor.
        /// </summary>
        [Convention]
        public readonly int COLOR_CLEAR_VALUE;

        /// <summary>
        /// Passed to getParameter to get the red, green, blue, and alpha write enables for the color buffers.
        /// The initial value is (GL_TRUE, GL_TRUE, GL_TRUE, GL_TRUE).
        /// See glColorMask.
        /// </summary>
        [Convention]
        public readonly int COLOR_WRITEMASK;

        /// <summary>
        /// Passed to getParameter to get the byte alignment used for reading pixel data from memory.
        /// The initial value is 4.
        /// See glPixelStorei.
        /// </summary>
        [Convention]
        public readonly int UNPACK_ALIGNMENT;

        /// <summary>
        /// Passed to getParameter to get the byte alignment used for writing pixel data to memory.
        /// The initial value is 4.
        /// See glPixelStorei.
        /// </summary>
        [Convention]
        public readonly int PACK_ALIGNMENT;

        /// <summary>
        /// Passed to getParameter to get The value gives a rough estimate of the largest texture that the GL can handle. The value must be at least 64.
        /// See glTexImage2D.
        /// </summary>
        [Convention]
        public readonly int MAX_TEXTURE_SIZE;

        /// <summary>
        /// Passed to getParameter to get the maximum supported width and height of the viewport. These must be at least as large as the visible dimensions of the display being rendered to.
        /// See glViewport.
        /// </summary>
        [Convention]
        public readonly int MAX_VIEWPORT_DIMS;

        /// <summary>
        /// Passed to getParameter to get an estimate of the number of bits of subpixel resolution that are used to position rasterized geometry in window coordinates. The value must be at least 4.
        /// </summary>
        [Convention]
        public readonly int SUBPIXEL_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of red bitplanes in the color buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int RED_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of green bitplanes in the color buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int GREEN_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of blue bitplanes in the color buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int BLUE_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of alpha bitplanes in the color buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int ALPHA_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of bitplanes in the depth buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int DEPTH_BITS;

        /// <summary>
        /// Passed to getParameter to get the number of bitplanes in the stencil buffer of the currently bound framebuffer.
        /// </summary>
        [Convention]
        public readonly int STENCIL_BITS;

        /// <summary>
        /// Passed to getParameter to get the value that is multiplied by an implementation-specific value and then added to the depth value of each fragment generated when a polygon is rasterized.
        /// The initial value is 0.
        /// See glPolygonOffset.
        /// </summary>
        [Convention]
        public readonly int POLYGON_OFFSET_UNITS;

        #endregion

        #region POLYGON_OFFSET_FILL

        /// <summary>
        /// Passed to getParameter to get the scaling factor used to determine the variable offset that is added to the depth value of each fragment generated when a polygon is rasterized.
        /// The initial value is 0.
        /// See glPolygonOffset.
        /// </summary>
        [Convention]
        public readonly int POLYGON_OFFSET_FACTOR;

        /// <summary>
        /// Passed to getParameter to get the name of the texture currently bound to the target GL_TEXTURE_2D for the active multitexture unit.
        /// The initial value is 0.
        /// See glBindTexture.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_BINDING_2D;

        /// <summary>
        /// Passed to getParameter to get
        /// </summary>
        [Convention]
        public readonly int SAMPLE_BUFFERS;

        /// <summary>
        /// Passed to getParameter to get a single integer value indicating the number of sample buffers associated with the currently bound framebuffer.
        /// See glSampleCoverage.
        /// </summary>
        [Convention]
        public readonly int SAMPLES;

        /// <summary>
        /// Passed to getParameter to get a single positive floating-point value indicating the current sample coverage value.
        /// See glSampleCoverage.
        /// </summary>
        [Convention]
        public readonly int SAMPLE_COVERAGE_VALUE;

        /// <summary>
        /// Passed to getParameter to get a single boolean value indicating if the temporary coverage value should be inverted.
        /// See glSampleCoverage.
        /// </summary>
        [Convention]
        public readonly int SAMPLE_COVERAGE_INVERT;

        #endregion

        #region GetTextureParameter

        /// <summary>
        /// Passed to getParameter to get a list of symbolic constants of length GL_NUM_COMPRESSED_TEXTURE_FORMATS indicating which compressed texture formats are available.
        /// See glCompressedTexImage2D.
        /// </summary>
        [Convention]
        public readonly int COMPRESSED_TEXTURE_FORMATS;

        #endregion

        #region HintMode

        /// <summary>
        /// No preference.
        /// See glHint.
        /// </summary>
        [Convention]
        public readonly int DONT_CARE;

        /// <summary>
        /// The most efficient option should be chosen.
        /// See glHint.
        /// </summary>
        [Convention]
        public readonly int FASTEST;

        /// <summary>
        /// The most correct, or highest quality, option should be chosen.
        /// See glHint.
        /// </summary>
        [Convention]
        public readonly int NICEST;

        #endregion

        #region HintTarget

        /// <summary>
        /// Passed to getParameter to get a symbolic constant indicating the mode of the mipmap generation filtering hint.
        /// The initial value is GL_DONT_CARE.
        /// See glHint.
        /// </summary>
        [Convention]
        public readonly int GENERATE_MIPMAP_HINT;

        #endregion

        #region DataType

        /// <summary>
        /// The byte data type
        /// </summary>
        [Convention]
        public readonly int BYTE;

        /// <summary>
        /// The unsigned byte data type
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_BYTE;

        /// <summary>
        /// The short data type
        /// </summary>
        [Convention]
        public readonly int SHORT;

        /// <summary>
        /// The unsigned short data type
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_SHORT;

        /// <summary>
        /// The int data type
        /// </summary>
        [Convention]
        public readonly int INT;

        /// <summary>
        /// The unsigned int data type
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_INT;

        /// <summary>
        /// The float data type
        /// </summary>
        [Convention]
        public readonly int FLOAT;

        #endregion

        #region PixelFormat

        /// <summary>
        /// To be used for depth textures.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int DEPTH_COMPONENT;

        /// <summary>
        /// Each element is a single alpha component. The system converts it to floating point, clamped to the range [0, 1], and assembles it into an RGBA element by placing attaching 0.0 to the red, green and blue channels.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int ALPHA;

        /// <summary>
        /// Red, green, and blue channels.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int RGB;

        /// <summary>
        /// Red, green, blue, and alpha (transparency) channels.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int RGBA;

        /// <summary>
        /// Each element is a single luminance component. The system converts it to floating point value, clamped to the range [0, 1], and assembles it into an RGBA element by placing the luminance value in the red, green and blue channels, and attaching 1.0 to the alpha channel.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int LUMINANCE;

        /// <summary>
        /// Each element is an luminance/alpha double. The systems converts each component to floating point, clamped to the range [0, 1], and assembles them into an RGBA element by placing the luminance value in the red, green and blue channels.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int LUMINANCE_ALPHA;

        #endregion

        #region PixelType

        /// <summary>
        /// Represents colors in a Uint16Array where red = 4 bits, green=4 bits, blue=4 bits, and alpha=4 bits.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_SHORT_4_4_4_4;

        /// <summary>
        /// Represents colors in a Uint16Array where red = 5 bits, green=5 bits, blue=5 bits and alpha=1 bit.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_SHORT_5_5_5_1;

        /// <summary>
        /// Represents colors in a Uint16Array where red = 5 bits, green=6 bits, and blue=5 bits.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int UNSIGNED_SHORT_5_6_5;

        #endregion

        #region Shaders

        /// <summary>
        /// Passed to createShader to define a fragment shader.
        /// </summary>
        [Convention]
        public readonly int FRAGMENT_SHADER;

        /// <summary>
        /// Passed to createShader to define a vertex shader
        /// </summary>
        [Convention]
        public readonly int VERTEX_SHADER;

        /// <summary>
        /// Passed to getParameter to get the maximum number of 4-component generic vertex attributes accessible to a vertex shader. The value must be at least 8.
        /// See glVertexAttrib.
        /// </summary>
        [Convention]
        public readonly int MAX_VERTEX_ATTRIBS;

        /// <summary>
        /// Passed to getParameter to get the maximum number of four-element floating-point, integer, or boolean vectors that can be held in uniform variable storage for a vertex shader. The value must be at least 128.
        /// See glUniform.
        /// </summary>
        [Convention]
        public readonly int MAX_VERTEX_UNIFORM_VECTORS;

        /// <summary>
        /// Passed to getParameter to get the maximum number four-element floating-point vectors available for interpolating varying variables used by vertex and fragment shaders. Varying variables declared as matrices or arrays will consume multiple interpolators. The value must be at least 8.
        /// </summary>
        [Convention]
        public readonly int MAX_VARYING_VECTORS;

        /// <summary>
        /// Passed to getParameter to get the maximum supported texture image units that can be used to access texture maps from the vertex shader and the fragment processor combined.
        /// If both the vertex shader and the fragment processing stage access the same texture image unit, then that counts as using two texture image units against this limit.
        /// The value must be at least 8.
        /// See glActiveTexture.
        /// </summary>
        [Convention]
        public readonly int MAX_COMBINED_TEXTURE_IMAGE_UNITS;

        /// <summary>
        /// Passed to getParameter to get the maximum supported texture image units that can be used to access texture maps from the vertex shader. The value may be 0.
        /// See glActiveTexture.
        /// </summary>
        [Convention]
        public readonly int MAX_VERTEX_TEXTURE_IMAGE_UNITS;

        /// <summary>
        /// Passed to getParameter to get the maximum supported texture image units that  can be used to access texture maps from the fragment shader.
        /// The value must be at least 8.
        /// See glActiveTexture.
        /// </summary>
        [Convention]
        public readonly int MAX_TEXTURE_IMAGE_UNITS;

        /// <summary>
        /// Passed to getParameter to get the maximum number of four-element floating-point, integer, or boolean vectors that can be held in uniform variable storage for a fragment shader.
        /// The value must be at least 16.
        /// See glUniform.
        /// </summary>
        [Convention]
        public readonly int MAX_FRAGMENT_UNIFORM_VECTORS;

        /// <summary>
        /// Passed to getShaderParameter as pname.
        /// </summary>
        [Convention]
        public readonly int SHADER_TYPE;

        /// <summary>
        /// Passed to getShaderParameter to determine if a shader was deleted via deleteShader. Returns true if it was, false otherwise.
        /// </summary>
        [Convention]
        public readonly int DELETE_STATUS;

        /// <summary>
        /// Passed to getProgramParameter after calling linkProgram to determine if a program was linked correctly. Returns false if there were errors. Use getProgramInfoLog to find the exact error.
        /// </summary>
        [Convention]
        public readonly int LINK_STATUS;

        /// <summary>
        /// Passed to getProgramParameter after calling validateProgram to determine if it is valid. Returns false if errors were found.
        /// </summary>
        [Convention]
        public readonly int VALIDATE_STATUS;

        /// <summary>
        /// Passed to getProgramParameter after calling attachShader to determine if the shader was attached correctly. Returns false if errors occurred.
        /// </summary>
        [Convention]
        public readonly int ATTACHED_SHADERS;

        /// <summary>
        /// Passed to getProgramParameter to get the number of uniforms active in a program.
        /// </summary>
        [Convention]
        public readonly int ACTIVE_UNIFORMS;

        /// <summary>
        /// Passed to getProgramParameter to get the number of attributes active in a program.
        /// </summary>
        [Convention]
        public readonly int ACTIVE_ATTRIBUTES;

        /// <summary>
        /// Passed to getParameter to get the name of the program object that is currently active, or 0 if no program object is active.
        /// See glUseProgram.
        /// </summary>
        [Convention]
        public readonly int CURRENT_PROGRAM;

        #endregion

        #region StencilOp

        /// <summary>
        /// Passed to stencilOp. Keeps the current value.
        /// </summary>
        [Convention]
        public readonly int KEEP;

        /// <summary>
        /// Passed to stencilOp. Sets the stencil buffer value to ref, as specified by glStencilFunc.
        /// </summary>
        [Convention]
        public readonly int REPLACE;

        /// <summary>
        /// Passed to stencilOp. Increments the current stencil buffer value. Clamps to the maximum representable unsigned value.
        /// </summary>
        [Convention]
        public readonly int INCR;

        /// <summary>
        /// Passed to stencilOp. Decrements the current stencil buffer value. Clamps to 0.
        /// </summary>
        [Convention]
        public readonly int DECR;

        /// <summary>
        /// Passed to stencilOp. Bitwise inverts the current stencil buffer value.
        /// </summary>
        [Convention]
        public readonly int INVERT;

        /// <summary>
        /// Passed to stencilOp. Increments the current stencil buffer value. Wraps stencil buffer value to zero when incrementing the maximum representable unsigned value.
        /// </summary>
        [Convention]
        public readonly int INCR_WRAP;

        /// <summary>
        /// Passed to stencilOp. Decrements the current stencil buffer value. Wraps stencil buffer value to the maximum representable unsigned value when decrementing a stencil buffer value of zero.
        /// </summary>
        [Convention]
        public readonly int DECR_WRAP;

        #endregion

        #region WebGL implementation Info

        /// <summary>
        /// Passed to getParameter to get the company responsible for this WebGL implementation. This name does not change from release to release.
        /// </summary>
        [Convention]
        public readonly int VENDOR;

        /// <summary>
        /// Passed to getParameter to get the name of the renderer. This name is typically specific to a particular configuration of a hardware platform. It does not change from release to release.
        /// </summary>
        [Convention]
        public readonly int RENDERER;

        /// <summary>
        /// Passed to getParameter to get a version or release number of the form WebGL&lt;space&gt;1.0&lt;space&gt;&lt;vendor-specific information&gt;.
        /// </summary>
        [Convention]
        public readonly int VERSION;

        /// <summary>
        /// Passed to getParameter to get a version or release number of the form WebGL $lt;space$gt;GLSL$lt;space$gt;ES$lt;space$gt;1.0$lt;space$gt;$lt;vendor-specific information$gt;.
        /// </summary>
        [Convention]
        public readonly int SHADING_LANGUAGE_VERSION;

        #endregion

        #region TextureMagFilter

        /// <summary>
        /// Returns the value of the texture element that is nearest (in Manhattan distance) to the center of the pixel being textured.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int NEAREST;

        /// <summary>
        /// Returns the weighted average of the four texture elements that are closest to the center of the pixel being textured.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int LINEAR;

        #endregion

        #region TextureMinFilter

        /// <summary>
        /// Chooses the mipmap that most closely matches the size of the pixel being textured and uses the GL_NEAREST criterion (the texture element nearest to the center of the pixel) to produce a texture value.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int NEAREST_MIPMAP_NEAREST;

        /// <summary>
        /// Chooses the mipmap that most closely matches the size of the pixel being textured and uses the GL_LINEAR criterion (a weighted average of the four texture elements that are closest to the center of the pixel) to produce a texture value.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int LINEAR_MIPMAP_NEAREST;

        /// <summary>
        /// Chooses the two mipmaps that most closely match the size of the pixel being textured and uses the GL_NEAREST criterion (the texture element nearest to the center of the pixel) to produce a texture value from each mipmap. The final texture value is a weighted average of those two values.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int NEAREST_MIPMAP_LINEAR;

        /// <summary>
        /// Chooses the two mipmaps that most closely match the size of the pixel being textured and uses the GL_LINEAR criterion (a weighted average of the four texture elements that are closest to the center of the pixel) to produce a texture value from each mipmap. The final texture value is a weighted average of those two values.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int LINEAR_MIPMAP_LINEAR;

        #endregion

        #region TextureParameterName

        /// <summary>
        /// The texture magnification function is used when the pixel being textured maps to an area less than or equal to one texture element.
        /// It sets the texture magnification function to either GL_NEAREST or GL_LINEAR (see below). GL_NEAREST is generally faster than GL_LINEAR,
        /// but it can produce textured images with sharper edges because the transition between texture elements is not as smooth.
        /// The initial value of GL_TEXTURE_MAG_FILTER is GL_LINEAR.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_MAG_FILTER;

        /// <summary>
        /// The texture minifying function is used whenever the pixel being textured maps to an area greater than one texture element.
        /// There are six defined minifying functions. Two of them use the nearest one or nearest four texture elements to compute the texture value. The other four use mipmaps.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_MIN_FILTER;

        /// <summary>
        /// Sets the wrap parameter for texture coordinate s.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_WRAP_S;

        /// <summary>
        /// Sets the wrap parameter for texture coordinate t.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_WRAP_T;

        #endregion

        #region TextureTarget

        /// <summary>
        /// Represents a 2D image.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_2D;

        /// <summary>
        /// Represents a texture.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE;

        /// <summary>
        /// The texture is composed of six 2D images, one for each face of a cube.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP;

        /// <summary>
        /// Passed to getParameter to get the name of the texture currently bound to the target GL_TEXTURE_CUBE_MAP for the active multitexture unit.
        /// The initial value is 0.
        /// See glBindTexture.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_BINDING_CUBE_MAP;

        /// <summary>
        /// Image for the positive X face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_POSITIVE_X;

        /// <summary>
        /// Image for the negative X face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_NEGATIVE_X;

        /// <summary>
        /// Image for the positive Y face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_POSITIVE_Y;

        /// <summary>
        /// Image for the negative Y face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_NEGATIVE_Y;

        /// <summary>
        /// Image for the positive Z face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_POSITIVE_Z;

        /// <summary>
        /// Image for the negative Z face of the cube map.
        /// See texImage2D.
        /// </summary>
        [Convention]
        public readonly int TEXTURE_CUBE_MAP_NEGATIVE_Z;

        /// <summary>
        /// Passed to getParameter to get the value gives a rough estimate of the largest cube-map texture that the GL can handle.
        /// The value must be at least 16.
        /// See glTexImage2D.
        /// </summary>
        [Convention]
        public readonly int MAX_CUBE_MAP_TEXTURE_SIZE;

        #endregion

        #region TextureUnit

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE0;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE1;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE2;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE3;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE4;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE5;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE6;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE7;

        /// <summary>
        ///
        /// </summary>
        [Convention]
        public readonly int TEXTURE8;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE9;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE10;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE11;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE12;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE13;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE14;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE15;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE16;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE17;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE18;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE19;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE20;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE21;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE22;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE23;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE24;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE25;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE26;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE27;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE28;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE29;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE30;

        /// <summary>
        /// The texture number that is returned by getParameter(ACTIVE_TEXTURE) call.
        /// </summary>
        [Convention]
        public readonly int TEXTURE31;

        /// <summary>
        /// Passed to getParameter to get the active multitexture unit.
        /// The initial value is GL_TEXTURE0.
        /// See glActiveTexture.
        /// </summary>
        [Convention]
        public readonly int ACTIVE_TEXTURE;

        #endregion

        #region TextureWrapMode

        /// <summary>
        /// The wrap parameter for texture coordinate.
        /// REPEAT causes the  integer part of the coordinate to be ignored.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int REPEAT;

        /// <summary>
        /// The wrap parameter for texture coordinates.
        /// CLAMP_TO_EDGE causes coordinates to be clamped.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int CLAMP_TO_EDGE;

        /// <summary>
        /// The wrap parameter for texture coordinate.
        /// MIRRORED_REPEAT causes the s coordinate to be set to the fractional part of the texture coordinate.
        /// See glTexParameter.
        /// </summary>
        [Convention]
        public readonly int MIRRORED_REPEAT;

        #endregion

        #region Uniform Types

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_VEC2;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_VEC3;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_VEC4;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int INT_VEC3;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int INT_VEC4;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int BOOL;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int BOOL_VEC2;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int BOOL_VEC3;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int BOOL_VEC4;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_MAT2;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_MAT3;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int FLOAT_MAT4;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int SAMPLER_2D;

        /// <summary>
        /// The uniform variable type
        /// </summary>
        [Convention]
        public readonly int SAMPLER_CUBE;

        #endregion

        #region Vertex Arrays

        /// <summary>
        /// Passed to the getVertexAttrib to get a single value that is non-zero (true) if the vertex attribute array for index is enabled and 0 (false) if it is disabled.
        /// The initial value is GL_FALSE.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_ENABLED;

        /// <summary>
        /// Passed to the getVertexAttrib to get a single value, the size of the vertex attribute array for index. The size is the number of values for each element of the vertex attribute array, and it will be 1, 2, 3, or 4.
        /// The initial value is 4.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_SIZE;

        /// <summary>
        /// Passed to the getVertexAttrib to get a single value, the array stride for (number of bytes between successive elements in) the vertex attribute array for index. A value of 0 indicates that the array elements are stored sequentially in memory.
        /// The initial value is 0.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_STRIDE;

        /// <summary>
        /// Passed to the getVertexAttrib to get a single value, a symbolic constant indicating the array type for the vertex attribute array for index.
        /// Possible values are GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_FIXED and GL_FLOAT.
        /// The initial value is GL_FLOAT.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_TYPE;

        /// <summary>
        /// Passed to the getVertexAttrib to get a single value that is non-zero (true) if fixed-point data types for the vertex attribute array indicated by index are normalized when they are converted to floating point, and 0 (false) otherwise.
        /// The initial value is GL_FALSE.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_NORMALIZED;

        /// <summary>
        /// Passed to the vertexAttribPointer to get the address of the specified generic vertex attribute pointer.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_POINTER;

        /// <summary>
        /// Passed to the getVertexAttrib to get the the name of the buffer object currently bound to he binding point corresponding to generic vertex attribute array index.
        /// If no buffer object is bound, 0 is returned.
        /// The initial value is 0.
        /// </summary>
        [Convention]
        public readonly int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING;

        #endregion

        #region Read Format

        /// <summary>
        /// Passed to getParameter to get the type chosen by the implementation with which pixels may be read from the color buffer of the currently bound framebuffer in conjunction with GL_IMPLEMENTATION_COLOR_READ_FORMAT.
        /// In addition to this implementation-dependent format/type pair, format GL_RGBA in conjunction with type GL_UNSIGNED_BYTE is always allowed by every implementation, regardless of the currently bound render surface.
        /// See glReadPixels.
        /// </summary>
        [Convention]
        public readonly int IMPLEMENTATION_COLOR_READ_TYPE;

        /// <summary>
        /// Passed to getParameter to get the format chosen by the implementation in which pixels may be read from the color buffer of the currently bound framebuffer in conjunction with GL_IMPLEMENTATION_COLOR_READ_TYPE.
        /// In addition to this implementation-dependent format/type pair, format GL_RGBA in conjunction with type GL_UNSIGNED_BYTE is always allowed by every implementation, regardless of the currently bound render surface.
        /// See glReadPixels.
        /// </summary>
        [Convention]
        public readonly int IMPLEMENTATION_COLOR_READ_FORMAT;

        #endregion

        /// <summary>
        /// Passed to getShaderParameter to get the status of the compilation. Returns false if the shader was not compiled. You can then query getShaderInfoLog to find the exact error.
        /// </summary>
        [Convention]
        public readonly int COMPILE_STATUS;

        #region Shader Precision-Specified Types

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int LOW_FLOAT;

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int MEDIUM_FLOAT;

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int HIGH_FLOAT;

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int LOW_INT;

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int MEDIUM_INT;

        /// <summary>
        /// The shader precision type. See getShaderPrecisionFormat.
        /// </summary>
        [Convention]
        public readonly int HIGH_INT;

        #endregion

        #region Framebuffer Object

        /// <summary>
        /// Passed to bindFramebuffer as a target.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER;

        /// <summary>
        /// Passed to bindRenderbuffer as a target.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER;

        /// <summary>
        /// RGBA with 4 bits per channel.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int RGBA4;

        /// <summary>
        /// RGBA value with 5 bits for RGB and 1 bit for Alpha.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int RGB5_A1;

        /// <summary>
        /// RGB value with 5 bits red, 6 bits green, and 5 bits blue respectively.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int RGB565;

        /// <summary>
        /// 16 bit Depth component.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int DEPTH_COMPONENT16;

        /// <summary>
        /// The stencil-renderable format of the renderbuffer.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int STENCIL_INDEX;

        /// <summary>
        /// The stencil-renderable format of the renderbuffer.
        /// See renderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int STENCIL_INDEX8;

        /// <summary>
        /// Call renderbufferStorage with the DEPTH_STENCIL internal format to attach both depth and stencil buffers to a framebuffer object.
        /// </summary>
        [Convention]
        public readonly int DEPTH_STENCIL;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the width (in pixels).
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_WIDTH;

        /// <summary>
        /// Passed to getRenderbufferParameter to get The height (in pixels).
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_HEIGHT;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the internal format for the image.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_INTERNAL_FORMAT;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the red component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_RED_SIZE;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the green component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_GREEN_SIZE;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the blue component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_BLUE_SIZE;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the alpha component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_ALPHA_SIZE;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the depth component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_DEPTH_SIZE;

        /// <summary>
        /// Passed to getRenderbufferParameter to get the resolution size (in bits) for the stencil component.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_STENCIL_SIZE;

        /// <summary>
        /// Passed to getFramebufferAttachmentParameter to get the type of object which contains the attached image, either GL_RENDERBUFFER, GL_TEXTURE, or if no image is attached, GL_NONE.
        /// The initial value is GL_NONE.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE;

        /// <summary>
        /// Passed to getFramebufferAttachmentParameter as a parameter name.
        /// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_RENDERBUFFER, params returns the name of the renderbuffer object which contains the attached image.
        /// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_TEXTURE, params returns the name of the texture object which contains the attached image.
        /// The initial value is zero.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME;

        /// <summary>
        /// Passed to getFramebufferAttachmentParameter as a parameter name.
        /// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_TEXTURE, params returns the mipmap level of the texture object which contains the attached image.
        /// The initial value is zero.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL;

        /// <summary>
        /// Passed to getFramebufferAttachmentParameter as a parameter name.
        /// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_TEXTURE and  GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME is the name of a cube-map texture, params returns the cube map face of the cube-map texture object which contains the attached image.
        /// If the attached image is from a texture object but not a cube-map, params returns 0.
        /// The initial value is GL_TEXTURE_CUBE_MAP_POSITIVE_X.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE;

        /// <summary>
        /// Passed to getFramebufferAttachmentParam as an attacment type.
        /// </summary>
        [Convention]
        public readonly int COLOR_ATTACHMENT0;

        /// <summary>
        /// Passed to getFramebufferAttachmentParam as an attacment type.
        /// </summary>
        [Convention]
        public readonly int DEPTH_ATTACHMENT;

        /// <summary>
        /// Passed to getFramebufferAttachmentParam as an attacment type.
        /// </summary>
        [Convention]
        public readonly int STENCIL_ATTACHMENT;

        /// <summary>
        /// Passed to getFramebufferAttachmentParam as an attacment type.
        /// </summary>
        [Convention]
        public readonly int DEPTH_STENCIL_ATTACHMENT;

        /// <summary>
        /// The None constant
        /// </summary>
        [Convention]
        public readonly int NONE;

        /// <summary>
        /// The frame buffer is ready to display. A possible return value of a checkFramebufferStatus call.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_COMPLETE;

        /// <summary>
        /// The attachment types are mismatched. A possible return value of a checkFramebufferStatus call.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_INCOMPLETE_ATTACHMENT;

        /// <summary>
        /// There is no attachment. A possible return value of a checkFramebufferStatus call.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT;

        /// <summary>
        /// The height and width of the attachments are not the same. A possible return value of a checkFramebufferStatus call.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_INCOMPLETE_DIMENSIONS;

        /// <summary>
        /// The attachments aren't supported. A possible return value of a checkFramebufferStatus call.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_UNSUPPORTED;

        /// <summary>
        /// Passed to getParameter to get the name of the currently bound framebuffer.
        /// The initial value is 0, indicating the default framebuffer.
        /// See glBindFramebuffer.
        /// </summary>
        [Convention]
        public readonly int FRAMEBUFFER_BINDING;

        /// <summary>
        /// Passed to getParameter to get the name of the currently bound renderbuffer.
        /// The initial value is 0, indicating no renderbuffer is bound.
        /// See glBindRenderbuffer.
        /// </summary>
        [Convention]
        public readonly int RENDERBUFFER_BINDING;

        /// <summary>
        ///  Passed to getParameter to get the value indicates the largest renderbuffer width and height that the GL can handle.
        ///  The value must be at least 1.
        ///  See glRenderbufferStorage.
        /// </summary>
        [Convention]
        public readonly int MAX_RENDERBUFFER_SIZE;

        /// <summary>
        /// The command is trying to render to or read from the framebuffer while the currently bound framebuffer is not framebuffer complete (i.e. the return value from glCheckFramebufferStatus is not GL_FRAMEBUFFER_COMPLETE).
        /// The offending command is ignored and has no other side effect than to set the error flag.
        /// </summary>
        [Convention]
        public readonly int INVALID_FRAMEBUFFER_OPERATION;

        #endregion

        #region WebGL-specific enums

        /// <summary>
        /// Flips the source data along its vertical axis when texImage2D or texSubImage2D are called when param is true. The initial value for param is false.
        /// See pixelStorei.
        /// </summary>
        [Convention]
        public readonly int UNPACK_FLIP_Y_WEBGL;

        /// <summary>
        /// Multiplies the alpha channel, if it exists, into the other color channels during the data transfer when texImage2D or texSubImage2D are called when param is true. The initial value for param is false.
        /// See pixelStorei.
        /// </summary>
        [Convention]
        public readonly int UNPACK_PREMULTIPLY_ALPHA_WEBGL;

        /// <summary>
        /// If WebGL context is lost, this error is returned on the first call to getError. Subsequent calls return NO_ERROR until context is restored.
        /// </summary>
        [Convention]
        public readonly int CONTEXT_LOST_WEBGL;

        /// <summary>
        /// The browser's default colorspace conversion is applied when texImage2D or texSubImage2D are called with an HTMLImageElement texture data source. The initial value for param is BROWSER_DEFAULT_WEBGL. No colorspace conversion is applied when set to NONE.
        /// See pixelStorei.
        /// </summary>
        [Convention]
        public readonly int UNPACK_COLORSPACE_CONVERSION_WEBGL;

        /// <summary>
        /// If set to BROWSER_DEFAULT_WEBGL, then the browser's default colorspace conversion is applied during subsequent texImage2D and texSubImage2D calls taking HTMLImageElement. The precise conversions may be specific to both the browser and file type. If set to NONE, no colorspace conversion is applied. The initial value is BROWSER_DEFAULT_WEBGL.
        /// See pixelStorei.
        /// </summary>
        [Convention]
        public readonly int BROWSER_DEFAULT_WEBGL;

        #endregion
    }
}
