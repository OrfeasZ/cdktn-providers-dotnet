using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiClass(nativeType: typeof(scaleway.LbFrontend.LbFrontendAclOutputReference), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAclOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbFrontendAclOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbFrontendAclOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbFrontendAclOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbFrontendAclOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclAction\"}}]")]
        public virtual void PutAction(scaleway.LbFrontend.ILbFrontendAclAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbFrontend.ILbFrontendAclAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatch\"}}]")]
        public virtual void PutMatch(scaleway.LbFrontend.ILbFrontendAclMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.LbFrontend.ILbFrontendAclMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclActionOutputReference\"}")]
        public virtual scaleway.LbFrontend.LbFrontendAclActionOutputReference Action
        {
            get => GetInstanceProperty<scaleway.LbFrontend.LbFrontendAclActionOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatchOutputReference\"}")]
        public virtual scaleway.LbFrontend.LbFrontendAclMatchOutputReference Match
        {
            get => GetInstanceProperty<scaleway.LbFrontend.LbFrontendAclMatchOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclAction\"}", isOptional: true)]
        public virtual scaleway.LbFrontend.ILbFrontendAclAction? ActionInput
        {
            get => GetInstanceProperty<scaleway.LbFrontend.ILbFrontendAclAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatch\"}", isOptional: true)]
        public virtual scaleway.LbFrontend.ILbFrontendAclMatch? MatchInput
        {
            get => GetInstanceProperty<scaleway.LbFrontend.ILbFrontendAclMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.lbFrontend.LbFrontendAcl\"}]}}", isOptional: true)]
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
                        case scaleway.LbFrontend.ILbFrontendAcl cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.LbFrontend.ILbFrontendAcl).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
