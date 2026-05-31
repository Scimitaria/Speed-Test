package{
    import flash.display.Sprite;
    import flash.desktop.NativeApplication;
    public class sort extends Sprite{
        public function sort(){
            var arr:Array = [23, 69, 72, 41, 55, 6];
            arr.sort(Array.NUMERIC);
            NativeApplication.nativeApplication.exit();
        }
    }
}