using Data;

namespace View
{
    using UnityEngine;

    public class BoardRenderer : MonoBehaviour
    {
        [SerializeField] private BlockView _blockViewPrefab;
        [SerializeField] private Transform _root;
        [SerializeField] private BlockDatabase _blockDatabase;
        [SerializeField] private float _cellSize = 1f;

        private BlockView[,] _views;

        public void Render(BoardModel board)
        {
            Clear();

            _views = new BlockView[board.Width, board.Height];

            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    BlockModel block = board.GetBlock(x, y);
                    if (block.IsEmpty)
                        continue;

                    BlockDefinition definition = _blockDatabase.Get(block.Type);
                    if (definition == null)
                    {
                        Debug.LogError($"Missing BlockDefinition for type: {block.Type}");
                        continue;
                    }

                    BlockView view = Instantiate(_blockViewPrefab, _root);
                    view.transform.localPosition = GetLocalPosition(x, y);
                    view.Bind(block, definition, new Vector2Int(x, y));

                    _views[x, y] = view;
                }
            }
        }

        private Vector3 GetLocalPosition(int x, int y)
        {
            return new Vector3(x * _cellSize, y * _cellSize, 0f);
        }

        private void Clear()
        {
            if (_root == null)
                return;

            for (int i = _root.childCount - 1; i >= 0; i--)
            {
                Destroy(_root.GetChild(i).gameObject);
            }
        }
    }
}