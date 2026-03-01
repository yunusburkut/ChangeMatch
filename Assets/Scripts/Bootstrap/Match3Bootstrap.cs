using Data;
using Logic;
using View;

namespace Bootstrap
{
    using UnityEngine;

    public class Match3Bootstrap : MonoBehaviour
    {
        [SerializeField] private int _width = 8;
        [SerializeField] private int _height = 8;
        [SerializeField] private BoardRenderer _boardRenderer;
        [SerializeField] private BlockType[] _spawnableTypes =
        {
            BlockType.Red,
            BlockType.Blue,
            BlockType.Green,
            BlockType.Yellow,
            BlockType.Purple
        };

        private BoardModel _boardModel;
        private BoardGenerator _boardGenerator;

        private void Start()
        {
            _boardModel = new BoardModel(_width, _height);
            _boardGenerator = new BoardGenerator(_spawnableTypes);

            _boardGenerator.Fill(_boardModel);
            _boardRenderer.Render(_boardModel);
        }
    }
}