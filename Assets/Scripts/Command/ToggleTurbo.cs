using Chapter.EventBus;
using UnityEngine;

namespace Chapter.Commands
{
    public class ToggleTurbo : Command
    {
        private BikeController _controller;

        public ToggleTurbo(BikeController controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}
