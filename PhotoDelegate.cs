using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PhotoDelegate
    {
    }

    public class Photo
    {
        public string Name { get; set; }
        public static Photo Load (string str)
        {
            Console.WriteLine ($"正在加载照片：{str}");
            Photo photo = new Photo ();
            photo.Name = str;
            return photo;
        }
        public void Save ()
        {
            Console.WriteLine($"正在保存照片：{Name}");
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine($"图片{photo.Name}：亮度增加");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine($"图片{photo.Name}：对比度增加");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine($"图片{photo.Name}：尺寸放大");
        }
    }

    //public delegate void PhotoFilterHandler(Photo photo);

    public class PhotoProcessor
    {
        public void Process (Photo photo, Action<Photo> filterHandlers)
        {
            filterHandlers(photo);
            photo.Save();
        }
    }
}
