/*
 * Copyright (c) 2007, Ted Elliott
 * Code licensed under the New BSD License:
 * http://code.google.com/p/jsonexserializer/wiki/License
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonExSerializer.Framework.Expressions
{
    sealed class NullExpression : Expression
    {

        public override Type DefaultType
        {
            get { return typeof(object); }
        }
    }
}
