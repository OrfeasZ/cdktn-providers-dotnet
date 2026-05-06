using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputReference), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AiGatewayDynamicRoutingElementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AiGatewayDynamicRoutingElementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingElementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingElementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOutputs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs\"}}]")]
        public virtual void PutOutputs(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsProperties\"}}]")]
        public virtual void PutProperties(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetProperties")]
        public virtual void ResetProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsOutputReference Outputs
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsOutputReference>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsPropertiesOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsPropertiesOutputReference Properties
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs\"}]}}", isOptional: true)]
        public virtual object? OutputsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsProperties\"}]}}", isOptional: true)]
        public virtual object? PropertiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElements\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElements cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElements).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
