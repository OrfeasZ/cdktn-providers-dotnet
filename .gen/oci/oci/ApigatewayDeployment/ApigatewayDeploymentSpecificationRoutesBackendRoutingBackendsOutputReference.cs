using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackend", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend\"}}]")]
        public virtual void PutBackend(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey\"}}]")]
        public virtual void PutKey(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackend")]
        public virtual void ResetBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackendOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackendOutputReference Backend
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackendOutputReference>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKeyOutputReference\"}")]
        public virtual oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKeyOutputReference Key
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend? BackendInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsBackend?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey\"}", isOptional: true)]
        public virtual oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey? KeyInput
        {
            get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackendsKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackends\"}]}}", isOptional: true)]
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
                        case oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackends cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendRoutingBackends).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
