using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareOrganizationFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareOrganizationFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContaining", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining\"}}]")]
        public virtual void PutContaining(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining)}, new object[]{@value});
        }

        [JsiiMethod(name: "putName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName\"}}]")]
        public virtual void PutName(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent\"}}]")]
        public virtual void PutParent(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContaining")]
        public virtual void ResetContaining()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPageSize")]
        public virtual void ResetPageSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPageToken")]
        public virtual void ResetPageToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParent")]
        public virtual void ResetParent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContainingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterContainingOutputReference Containing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterContainingOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterNameOutputReference Name
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterNameOutputReference>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParentOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterParentOutputReference Parent
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganization.DataCloudflareOrganizationFilterParentOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining\"}]}}", isOptional: true)]
        public virtual object? ContainingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IdInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName\"}]}}", isOptional: true)]
        public virtual object? NameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PageSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PageTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent\"}]}}", isOptional: true)]
        public virtual object? ParentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Id
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PageSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pageToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PageToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilter\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
