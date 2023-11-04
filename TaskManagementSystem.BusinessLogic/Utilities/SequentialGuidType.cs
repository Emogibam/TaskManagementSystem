using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.BusinessLogic.Utilities
{
    public enum SequentialGuidType
    {
        SequentialAsString,
        SequentialAsBinary,
        SequentialAtEnd
    }

    public static class SequentialGuid
    {
        public static Guid Create(SequentialGuidType guidType = SequentialGuidType.SequentialAsString)
        {
            byte[] randomBytes = Guid.NewGuid().ToByteArray();

            long timeStamp = DateTime.UtcNow.Ticks / 10000L;

            var timeStampsBytes = BitConverter.GetBytes(timeStamp);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timeStampsBytes);
            }

            var guidesBytes = new byte[16];


            switch (guidType)
            {
                case SequentialGuidType.SequentialAsString:
                case SequentialGuidType.SequentialAsBinary:
                    Buffer.BlockCopy(timeStampsBytes, 2, guidesBytes, 0, 6);
                    Buffer.BlockCopy(randomBytes, 0, guidesBytes, 6, 10);

                    if (guidType == SequentialGuidType.SequentialAsString && BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(guidesBytes, 0, 4);
                        Array.Reverse(guidesBytes, 4, 2);
                    }
                    break; // Add break statement here

                case SequentialGuidType.SequentialAtEnd:
                    Buffer.BlockCopy(randomBytes, 0, guidesBytes, 0, 10);
                    Buffer.BlockCopy(timeStampsBytes, 2, guidesBytes, 10, 6);
                    break; // Add break statement here

                default:
                    throw new Exception($"Case missing for {guidType}");
            }

            return new Guid(guidesBytes);
        }
    }
}
