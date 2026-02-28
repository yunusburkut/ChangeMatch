using Data;

namespace View
{
    using UnityEngine;

    public class BlockView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public Vector2Int GridPosition { get; private set; }

        public void Bind(in BlockModel model, BlockDefinition definition, Vector2Int gridPosition)
        {
            GridPosition = gridPosition;
            _spriteRenderer.sprite = definition.sprite;
            gameObject.name = $"Block_{gridPosition.x}_{gridPosition.y}_{model.Type}";
        }
    }
}