using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiClass(nativeType: typeof(aws.DatazonePolicyGrant.DatazonePolicyGrantDetailOutputReference), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatazonePolicyGrantDetailOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatazonePolicyGrantDetailOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatazonePolicyGrantDetailOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatazonePolicyGrantDetailOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool" />)[]</param>
        [JsiiMethod(name: "putAddToProjectMemberPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPool\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAddToProjectMemberPool(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType" />)[]</param>
        [JsiiMethod(name: "putCreateAssetType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateAssetType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit" />)[]</param>
        [JsiiMethod(name: "putCreateDomainUnit", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnit\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateDomainUnit(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment" />)[]</param>
        [JsiiMethod(name: "putCreateEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateEnvironment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint" />)[]</param>
        [JsiiMethod(name: "putCreateEnvironmentFromBlueprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateEnvironmentFromBlueprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile" />)[]</param>
        [JsiiMethod(name: "putCreateEnvironmentProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateEnvironmentProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType" />)[]</param>
        [JsiiMethod(name: "putCreateFormType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateFormType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateFormType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary" />)[]</param>
        [JsiiMethod(name: "putCreateGlossary", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossary\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateGlossary(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject" />)[]</param>
        [JsiiMethod(name: "putCreateProject", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProject\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateProject(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile" />)[]</param>
        [JsiiMethod(name: "putCreateProjectFromProjectProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreateProjectFromProjectProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile" />)[]</param>
        [JsiiMethod(name: "putDelegateCreateEnvironmentProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDelegateCreateEnvironmentProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners" />)[]</param>
        [JsiiMethod(name: "putOverrideDomainUnitOwners", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwners\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOverrideDomainUnitOwners(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners" />)[]</param>
        [JsiiMethod(name: "putOverrideProjectOwners", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwners\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOverrideProjectOwners(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType" />)[]</param>
        [JsiiMethod(name: "putUseAssetType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUseAssetType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddToProjectMemberPool")]
        public virtual void ResetAddToProjectMemberPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAssetType")]
        public virtual void ResetCreateAssetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateDomainUnit")]
        public virtual void ResetCreateDomainUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateEnvironment")]
        public virtual void ResetCreateEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateEnvironmentFromBlueprint")]
        public virtual void ResetCreateEnvironmentFromBlueprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateEnvironmentProfile")]
        public virtual void ResetCreateEnvironmentProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateFormType")]
        public virtual void ResetCreateFormType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateGlossary")]
        public virtual void ResetCreateGlossary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateProject")]
        public virtual void ResetCreateProject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateProjectFromProjectProfile")]
        public virtual void ResetCreateProjectFromProjectProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelegateCreateEnvironmentProfile")]
        public virtual void ResetDelegateCreateEnvironmentProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideDomainUnitOwners")]
        public virtual void ResetOverrideDomainUnitOwners()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideProjectOwners")]
        public virtual void ResetOverrideProjectOwners()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseAssetType")]
        public virtual void ResetUseAssetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "addToProjectMemberPool", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPoolList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPoolList AddToProjectMemberPool
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPoolList>()!;
        }

        [JsiiProperty(name: "createAssetType", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetTypeList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetTypeList CreateAssetType
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetTypeList>()!;
        }

        [JsiiProperty(name: "createDomainUnit", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnitList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnitList CreateDomainUnit
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnitList>()!;
        }

        [JsiiProperty(name: "createEnvironment", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentList CreateEnvironment
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentList>()!;
        }

        [JsiiProperty(name: "createEnvironmentFromBlueprint", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprintList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprintList CreateEnvironmentFromBlueprint
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprintList>()!;
        }

        [JsiiProperty(name: "createEnvironmentProfile", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfileList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfileList CreateEnvironmentProfile
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfileList>()!;
        }

        [JsiiProperty(name: "createFormType", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateFormTypeList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateFormTypeList CreateFormType
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateFormTypeList>()!;
        }

        [JsiiProperty(name: "createGlossary", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossaryList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossaryList CreateGlossary
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossaryList>()!;
        }

        [JsiiProperty(name: "createProject", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectList CreateProject
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectList>()!;
        }

        [JsiiProperty(name: "createProjectFromProjectProfile", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfileList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfileList CreateProjectFromProjectProfile
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfileList>()!;
        }

        [JsiiProperty(name: "delegateCreateEnvironmentProfile", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfileList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfileList DelegateCreateEnvironmentProfile
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfileList>()!;
        }

        [JsiiProperty(name: "overrideDomainUnitOwners", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwnersList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwnersList OverrideDomainUnitOwners
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwnersList>()!;
        }

        [JsiiProperty(name: "overrideProjectOwners", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwnersList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwnersList OverrideProjectOwners
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwnersList>()!;
        }

        [JsiiProperty(name: "useAssetType", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetTypeList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantDetailUseAssetTypeList UseAssetType
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantDetailUseAssetTypeList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailAddToProjectMemberPool" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addToProjectMemberPoolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailAddToProjectMemberPool\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AddToProjectMemberPoolInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateAssetType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createAssetTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateAssetType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateAssetTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateDomainUnit" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createDomainUnitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateDomainUnit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateDomainUnitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentFromBlueprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironmentFromBlueprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentFromBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateEnvironmentFromBlueprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateEnvironmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateEnvironmentProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createEnvironmentProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateEnvironmentProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateFormType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createFormTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateFormType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateFormTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createGlossaryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateGlossaryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProjectFromProjectProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createProjectFromProjectProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProjectFromProjectProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateProjectFromProjectProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateProject" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createProjectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateProject\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreateProjectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailDelegateCreateEnvironmentProfile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "delegateCreateEnvironmentProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailDelegateCreateEnvironmentProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DelegateCreateEnvironmentProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideDomainUnitOwners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideDomainUnitOwnersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideDomainUnitOwners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OverrideDomainUnitOwnersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailOverrideProjectOwners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideProjectOwnersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailOverrideProjectOwners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OverrideProjectOwnersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailUseAssetType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useAssetTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetailUseAssetType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UseAssetTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantDetail" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantDetail\"}]}}", isOptional: true)]
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
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantDetail cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantDetail).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
