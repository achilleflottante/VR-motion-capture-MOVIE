import numpy as np


# ----------------------- Measurement matrix ----------------------------------#

class Sensor:
    
    """
    Linear sensing operator
    
    The linear sensing operator works by first computing the 2D Fourier
    transform of the input image and by retaining only a subset of p
    Fourier coefficients as measurements 
    
    Parameters
    ----------
    
    N: int
      image size e.g the image shape is N x N
    p: int
      number of measurements kept 
      
    Attributes
    ----------
    
    N: int
      image size e.g. the image shape is N x N
    F: 2D numpy array
      matrix operator used to represent the 2D Fourier transform, with size
      (n x n), n = N x N being the number of pixels in the image
    M: 2D numpy array
      measurement matrix obtained by retaining p rows of the matrix A
    indices: array-like
      array indicating the rows of the matrix A kept as measurements
         
    """

    def __init__(self, N, p):
    
        self.N = N
        self.indices = np.concatenate((np.array([0]), 
         np.random.choice(np.arange(1, N*N), p-1, replace=False)))

        
    def get_measurement_matrix(self):
        
        """
        Computes and returns the matrix associated with the forward operator

        Returns
        -------
        
        out: (2D numpy array, 2D numpy array)
          matrix operator used to represent the 2D Fourier transform and 
          measurement matrix
        """
        
        self.F = np.zeros((self.N*self.N, self.N*self.N), dtype='complex')
        for x in range(self.N):
            for y in range(self.N):
                
                im = np.zeros((self.N, self.N))
                im[x, y] = 1
                imhat = np.fft.fft2(im, norm='ortho').ravel() 
                self.F[:, y + self.N*x] = imhat
        
        self.mask = np.zeros((self.N*self.N), dtype='bool')
        self.mask[self.indices] = True  
        self.M = self.F[self.mask, :]
             
        return self.F, self.M
        
        
# ------------------------------------------------------------------------------
# when executed, run the main script
# ------------------------------------------------------------------------------
if __name__ == '__main__':

    # Quick test
    N = 3
    p = 2
    sensor = Sensor(N, p)
    F, M = sensor.get_measurement_matrix()
    img = np.arange(N*N).reshape((N, N))
    img_hat = np.fft.fft2(img, norm='ortho').ravel()
    img_hat_matrix = F @ img.ravel()
    print(img_hat)
    print(img_hat_matrix)
    
    
    
    
