using Data;

namespace Logic
{
    using UnityEngine;

    public class BoardGenerator
    {
        private readonly BlockType[] _spawnableTypes;

        public BoardGenerator(BlockType[] spawnableTypes)
        {
            _spawnableTypes = spawnableTypes;
        }

        public void Fill(BoardModel board)
        {
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    BlockModel block = new BlockModel
                    {
                        Type = GetRandomType(),
                        Kind = BlockKind.Normal
                    };

                    board.SetBlock(x, y, block);
                }
            }
        }

        private BlockType GetRandomType()
        {
            int index = Random.Range(0, _spawnableTypes.Length);
            return _spawnableTypes[index];
        }
    }
}