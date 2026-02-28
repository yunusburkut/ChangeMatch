namespace Data
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Match3/Block Definition", fileName = "BlockDefinition_")]
    public class BlockDefinition : ScriptableObject
    {
        public BlockType type;
        public Sprite sprite;
    }
}