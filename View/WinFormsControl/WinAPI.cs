
namespace WinFormsControl
{

internal class WinAPI
{

    public const int SRCCOPY = 0xCC0020;

    [DllImport("gdi32.dll")]
    public static extern int BitBlt(
        IntPtr hDestDC,
        int x,
        int y,
        int nWidth,
        int nHeight,
        IntPtr hSrcDC,
        int xSrc,
        int ySrc,
        int dwRop);

}   //  End of class WinAPI

}   //  End of namespace WinFormsControl
