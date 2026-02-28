namespace Data
{
    using System;

    public class BoardModel
    {
        private readonly int _width;
        private readonly int _height;
        private readonly BlockModel[] _blocks;

        public int Width => _width;
        public int Height => _height;

        public BoardModel(int width, int height)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width));
            if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height));

            _width = width;
            _height = height;
            _blocks = new BlockModel[width * height];
        }

        public bool IsInside(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }

        public int GetIndex(int x, int y)
        {
            return x + y * _width;
        }

        public BlockModel GetBlock(int x, int y)
        {
            return _blocks[GetIndex(x, y)];
        }

        public void SetBlock(int x, int y, in BlockModel block)
        {
            _blocks[GetIndex(x, y)] = block;
        }

        public ref BlockModel GetBlockRef(int x, int y)
        {
            return ref _blocks[GetIndex(x, y)];
        }
    }
}