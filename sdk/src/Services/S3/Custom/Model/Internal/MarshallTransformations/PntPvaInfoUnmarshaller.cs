using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PntPvaInfo Object
    /// </summary>  
    public class PntPvaInfoUnmarshaller : IUnmarshaller<PntPvaInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PntPvaInfo Unmarshall(XmlUnmarshallerContext context)
        {
            PntPvaInfo unmarshalledObject = new PntPvaInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Uuid", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Uuid = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Offset", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.Offset = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.TotalCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }
            return unmarshalledObject;
        }

        private static PntPvaInfoUnmarshaller _instance = new PntPvaInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PntPvaInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}

