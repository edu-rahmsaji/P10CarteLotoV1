using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P10CarteLotoV1
{
    internal class Card
    {
        private readonly Box[] boxes = new Box[15];
        private readonly string serialNumber = Guid.NewGuid().ToString();

        public Card()
        {
            this.GenerateBoxes();
        }

        /// <summary>
        /// Displays the card in a simple text format.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Display()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Displays a light version of the card in the format `SerialNumber : "04-34-45 ... 87-90"`.
        /// </summary>
        public void DisplayLight()
        {
            string message = $"{this.serialNumber} : ";

            for (int i = 0; i < this.boxes.Length; i++)
            {
                message += this.boxes.ElementAt(i).Value;

                if (i != this.boxes.Length - 1)
                {
                    message += "-";
                }
            }

            // TODO : Display the message on the screen.
        }

        /// <summary>
        /// Generates the boxes for the card in a way that the card is ergonomic.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        private void GenerateBoxes()
        {
            throw new System.NotImplementedException();
        }
    }
}