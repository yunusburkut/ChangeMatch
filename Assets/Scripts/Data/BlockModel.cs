namespace Data
{
    public struct BlockModel
    {
        public BlockType Type;
        public BlockKind Kind;

        public bool IsEmpty => Type == BlockType.None;
    }
}