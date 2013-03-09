//
// Encog(tm) Core v3.1 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2012 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace Encog.ML
{
    /// <summary>
    /// Defines a Machine Learning Method that can be encoded to a double array.  
    /// This is very useful for certain training, such as genetic algorithms 
    /// and simulated annealing. 
    /// </summary>
    ///
    public interface IMLEncodable : IMLMethod
    {
        /// <returns>The length of an encoded array.</returns>
        int EncodedArrayLength();

        /// <summary>
        /// Encode the object to the specified array.
        /// </summary>
        ///
        /// <param name="encoded">The array.</param>
        void EncodeToArray(double[] encoded);

        /// <summary>
        /// Decode an array to this object.
        /// </summary>
        ///
        /// <param name="encoded">The encoded array.</param>
        void DecodeFromArray(double[] encoded);
    }
}