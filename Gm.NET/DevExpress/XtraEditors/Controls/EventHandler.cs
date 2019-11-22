using System;

namespace DevExpress.XtraEditors.Controls
{
    internal class EventHandler
    {
        private object miBoton;

        public EventHandler(object miBoton)
        {
            this.miBoton = miBoton;
        }

        public EventHandler(Action<object, EventArgs> miBoton)
        {
            this.miBoton = miBoton;
        }
    }
}