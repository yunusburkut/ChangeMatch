namespace Data
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Match3/Block Database", fileName = "BlockDatabase")]
    public class BlockDatabase : ScriptableObject
    {
        [SerializeField] private BlockDefinition[] _definitions;

        public BlockDefinition Get(BlockType type)
        {
            if (type == BlockType.None)
                return null;

            for (int i = 0; i < _definitions.Length; i++)
            {
                BlockDefinition definition = _definitions[i];
                if (definition != null && definition.type == type)
                    return definition;
            }

            return null;
        }
    }
}